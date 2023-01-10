using Newtonsoft.Json.Linq;
using PWS_3.Models;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;
using static System.Int32;

namespace PWS_3.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly DB_Context _context = new DB_Context();

        [HttpGet]
        public object GetJson(HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            const string format = "json";

            return HandleGetPart(uri, format);
        }


        [HttpGet]
        public object GetJson1(HttpRequestMessage request, string root)
        {
            var uri = request.RequestUri;
            var format = root == "Students.json" ? "json" : "xml";

            var data = HandleGetPart(uri, format);
            return data;
        }

        private object HandleGetPart(Uri uri, string format)
        {
            try
            {
                //limit
                var limitV = HttpUtility.ParseQueryString(uri.Query).Get("limit");
                var offsetV = HttpUtility.ParseQueryString(uri.Query).Get("offset");
                var minIdV = HttpUtility.ParseQueryString(uri.Query).Get("minid");
                var maxIdV = HttpUtility.ParseQueryString(uri.Query).Get("maxid");
                var columns = HttpUtility.ParseQueryString(uri.Query).Get("columns");
                var globalLike = HttpUtility.ParseQueryString(uri.Query).Get("globallike");

                var limit = limitV == null ? 50 : Parse(limitV);
                var offset = offsetV == null ? 0 : Parse(offsetV);
                var minId = minIdV == null ? 0 : Parse(minIdV);
                var maxId = maxIdV == null ? 0 : Parse(maxIdV);
                var sort = HttpUtility.ParseQueryString(uri.Query).Get("sort");
                var like = HttpUtility.ParseQueryString(uri.Query).Get("like");
                var students = _context.GetList(limit, sort, offset, minId, maxId, like, globalLike);

                bool isId = false, isName = false, isNumber = false;
                if (columns != "")
                {
                    isId = columns.Contains("id");
                    isName = columns.Contains("name");
                    isNumber = columns.Contains("number");
                }
                else
                {
                    isId = true;
                    isName = true;
                    isNumber = true;
                }

                var result =
                    students.Select(student =>
                        new StudentDto(student)
                        {
                            Links = new[]
                            {
                                new Link("/api/students/" + student.Id, "GET", "Get students"),
                                new Link("/api/students/" + student.Id, "PUT", "Update students"),
                                new Link("/api/students/" + student.Id, "DELETE", "Delete students")
                            },
                            IdSpecified = isId,
                            NameSpecified = isName,
                            NumberSpecified = isNumber
                        }).ToList();

                if (format != null && format == "json")
                {
                    return Json(result);
                }

                var res = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\n";
                foreach (var student in result)
                {
                    var xml = "";
                    using (var stringwriter = new System.IO.StringWriter())
                    {
                        var serializer = new XmlSerializer(student.GetType());
                        serializer.Serialize(stringwriter, student);
                        xml = stringwriter.ToString();
                    }
                    res += xml.Substring(xml.IndexOf('>') + 3);
                }

                return Content(HttpStatusCode.OK, result);
            }
            catch (Exception exception)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.XmlFormatter);
            }
        }

        [HttpGet]
        public object Get(int id, HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            var format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            try
            {
                var student = _context.GetOne(id);
                var dto = new StudentDto(student);

                Link[] links = {
                    new Link("/api/students/" + id, "PUT", "Update"),
                    new Link("/api/students/" + id, "DELETE", "Delete")
                };

                dto.Links = links;

                if (format != null && format == "json")
                {
                    return Json(dto);
                }

                return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception exception)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.XmlFormatter);
            }
        }

        [HttpPost]
        public object Post(HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            var format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            var json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            if (data.name == null || data.number == null)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(400), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(400), Configuration.Formatters.XmlFormatter);
            }

            try
            {
                var nam = Convert.ToString(data.name);
                var num = Convert.ToString(data.number);
                var student = _context.Post(nam, num);
                var dto = new StudentDto(student);

                Link[] links = {
                    new Link("/api/students/" + student.Id, "GET", "Получить студента"),
                };
                dto.Links = links;

                if (format == "json")
                    return Json(dto);

                return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception exception)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(500, exception.Message), Configuration.Formatters.XmlFormatter);
            }
        }

        [HttpPut]
        public object Put(int id, HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            var format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            var json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);
            try
            {
                var student = _context.Put(id, Convert.ToString(data.name), Convert.ToString(data.number));
                var dto = new StudentDto(student);

                Link[] links = {
                    new Link("/api/students/" + id, "GET", "Получить студента"),
                    new Link("/api/students/" + id, "DELETE", "Удалить студента")
                };
                dto.Links = links;

                if (format == "json")
                    return Json(dto);

                return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
            }

        }

        [HttpDelete]
        public object Delete(int id, HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            var format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var body = request.Content;
            var json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);
            try
            {
                var student = _context.Delete(id);
                var dto = new StudentDto(student);

                if (format == "json")
                    return Json(dto);
                return Content(HttpStatusCode.OK, dto, Configuration.Formatters.XmlFormatter);
            }
            catch (Exception)
            {
                return format == "json"
                    ? Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.JsonFormatter)
                    : Content(HttpStatusCode.BadRequest, new ErrorDto(500), Configuration.Formatters.XmlFormatter);
            }
        }

        private string GenerateXmlResponse(Object obj)
        {
            Type t = obj.GetType();

            var xml = "";

            using (StringWriter sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    var ns = new XmlSerializerNamespaces();
                    // add empty namespace
                    ns.Add("", "");
                    XmlSerializer xsSubmit = new XmlSerializer(t);
                    xsSubmit.Serialize(writer, obj, ns);
                    xml = sww.ToString(); // Your XML
                }
            }
            return xml;
        }
    }

}
