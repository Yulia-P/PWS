using solution.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace solution
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [WebService(Namespace = "http://pys/", Description = "Simplex Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [ScriptService]
    public class Simplex : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "add", Description = "Sum of 2 int")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "concat", Description = "Concatination of string and double")]
        public string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [WebMethod(MessageName = "sum", Description = "Sum of 2 A instances. Response JSON")]
        public A Sum(A msu1, A msu2)
        {
            string body = requestBody(Context.Request);
            A a = new A();
            a.s = msu1.s + msu2.s;
            a.k = msu1.k + msu2.k;
            a.f = msu1.f + msu2.f;
            return a;
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "adds", Description = "Sum of 2 int. Response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }

        private string requestBody(HttpRequest request)
        {
            request.InputStream.Position = 0;
            var body = string.Empty;

            using (StreamReader readStream = new StreamReader(request.InputStream))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\37529\Documents\1Uni\ПWС(Смелов)\Лабораторные\lab4\solution\ReqBody.txt", true))
                {
                    body = readStream.ReadToEnd();
                    writer.WriteLine(body);
                }
            }

            return body;
        }
    }
}
