using PWS_3.Models;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace PWS_3.Controllers
{
    public class ErrorsController : ApiController
    {
        [HttpGet]
        public object GetErrors(int code, HttpRequestMessage request)
        {
            var uri = request.RequestUri;
            var format = HttpUtility.ParseQueryString(uri.Query).Get("format");
            var result = new ErrorDto(code, GetErrorMessage(code));

            return format == "json"
                ? (object)Json(result)
                : Content(HttpStatusCode.OK, result, Configuration.Formatters.XmlFormatter);
        }


        public static string GetErrorMessage(int code)
        {
            switch (code)
            {
                case 500:
                    return "Server Error";
                case 400:
                    return "Invalid parameters";
                default:
                    return "invalid error code";
            }
        }
    }
}