using System;
using System.Web;
using System.IO;

namespace Lab01
{
    public class IISHandler2 : IHttpHandler
    {

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }



        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            string htmlPage = File.ReadAllText(@"C:\пwс\pws\HtmlPage1.html");
            //string htmlPage = File.ReadAllText(@"C:\Users\37529\Documents\GitHub\PWS\Lab01\Lab01\HtmlPage1.html");

            response.ContentType = "text/html";
            response.Write(htmlPage);
        }

    }
}
