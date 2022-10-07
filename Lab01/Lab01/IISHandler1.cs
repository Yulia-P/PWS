using System;
using System.Net.Http;
using System.Web;
using System.Web.SessionState;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab01
{
    public class IISHandler1 : IHttpHandler, IRequiresSessionState
    {
        private static int RESULT = 0;

        public bool IsReusable
        {
            get { return true; }
        }

        private int Result(Stack<int> stack)
        {
            int peek = stack.Count > 0 ? stack.Peek() : 0;
            return RESULT + peek;
        }

        private string JsonResponse(HttpContext context)
        {
            return JsonConvert.SerializeObject(Result(SessionStack(context)));
        }

        private void SendJsonResponse(HttpResponse response, HttpContext context)
        {
            response.ContentType = "application/json";
            response.Write(JsonResponse(context));
        }

        private void SendJsonStackResponse(HttpResponse response, Stack<int> stack)
        {
            response.ContentType = "application/json";
            response.Write(JsonConvert.SerializeObject(stack));
        }

        private Stack<int> SessionStack(HttpContext context)
        {
            if (context.Session.Count == 0)
                context.Session.Add("stack", new Stack<int>());

            return (Stack<int>)context.Session["stack"];
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            HttpRequest req = context.Request;

            if (req.HttpMethod == HttpMethod.Get.ToString())
            {
                SendJsonResponse(res, context);
            }
            else if (req.HttpMethod == HttpMethod.Post.ToString())
            {
                string newResult = req.QueryString.Get("RESULT");
                if (!String.IsNullOrEmpty(newResult))
                    RESULT = int.Parse(newResult);

                SendJsonResponse(res, context);
            }
            else if (req.HttpMethod == HttpMethod.Put.ToString())
            {
                string element = req.QueryString.Get("ADD");
                if (!String.IsNullOrEmpty(element))
                    SessionStack(context).Push(int.Parse(element));

                SendJsonStackResponse(res, SessionStack(context));
            }
            else if (req.HttpMethod == HttpMethod.Delete.ToString())
            {
                if (SessionStack(context).Count != 0)
                    SessionStack(context).Pop();

                SendJsonStackResponse(res, SessionStack(context));
            }
        }
    }
}
