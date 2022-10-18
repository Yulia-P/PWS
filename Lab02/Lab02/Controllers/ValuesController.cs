using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;

namespace Lab02.Controllers
{
    public class ValuesController : ApiController, IRequiresSessionState
    {
        private HttpSessionState session = HttpContext.Current.Session;
        private static Stack<int> globalStack = new Stack<int>();
        private static int Result = 0;


        public int Get()
        {
            int result = Result;
            if (globalStack.Count != 0)
            {
                result += globalStack.Peek();
            }

            return result;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            string res = ParamByName("RESULT");
            if (!string.IsNullOrEmpty(res))
            {
                Result = int.Parse(res);
                //SetResult(int.Parse(res));
            }
        }

        // PUT api/values
        public string Put([FromBody] string value)
        {
            string element = ParamByName("ADD");
            if (!string.IsNullOrEmpty(element))
            {
                globalStack.Push(int.Parse(element));
            }

            return JsonConvert.SerializeObject(globalStack);
        }

        // DELETE api/values
        public string Delete()
        {
            if (globalStack.Count != 0)
            {
                globalStack.Pop();
            }

            return JsonConvert.SerializeObject(globalStack);
        }

        private string ParamByName(string paramName)
        {
            string uri = Request.RequestUri.Query;
            return HttpUtility.ParseQueryString(uri).Get(paramName);
        }

        private int GetResult()
        {
            if (session.Count == 0)
                session.Add("RESULT", 0);

            return (int)session["RESULT"];
        }

        private void SetResult(int? value)
        {
            if (value != null)
            {
                session["RESULT"] = value;
            }
        }
    }
}