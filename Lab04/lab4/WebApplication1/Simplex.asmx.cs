using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using WebServer.server;



namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для Simplex
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class Simplex : WebServer.server.Simplex
    {

        [WebMethod(MessageName = "add", Description = "Sum of 2 int")]
        public override int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "concat", Description = "Concatination of string and double")]
        public override string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [WebMethod(MessageName = "sum", Description = "Sum of 2 A instances. Response JSON")]
        public override A Sum(A msu1, A msu2)
        {
            string body = requestBody(Context.Request);
            A a = new A();
            a.s = msu1.s + msu2.s;
            a.k = msu1.k + msu2.k;
            a.f = msu1.f + msu2.f;
            return a;
        }

        [WebMethod(MessageName = "adds", Description = "Sum of 2 int. Response JSON")]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public override int Adds(int x, int y)
        {
            return x + y;
        }

        private string requestBody(HttpRequest request)
        {
            request.InputStream.Position = 0;
            var body = string.Empty;

            using (StreamReader readStream = new StreamReader(request.InputStream))
            {
                body = readStream.ReadToEnd();
            }

            return body;
        }
    }
}
