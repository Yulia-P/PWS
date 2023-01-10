using Lab_8.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_8.Controllers
{
    public class JRServiceController : Controller
    {
        private static bool ignoreMethods = false;
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Multi(ReqJsonRPC[] body)
        {
            int length = body.Length;
            List<JsonResult> result = new List<JsonResult>();

            for (int i = 0; i < length; i++)
            {
                if (!ignoreMethods)
                    result.Add(Single(body[i]));
            }
            ignoreMethods = false;
            return Json(result.Select(r => r.Data));
        }

        [HttpPost]
        public JsonResult Single(ReqJsonRPC body)
        {
            string method = body.Method;
            Data param = body.Params;
            string jsonrpc = body.Jsonrpc;

           
            if (param == null)
            {
                return Json(body, JsonRequestBehavior.AllowGet);
            }
            int? result = null;

            string key = param.Key;
            int value;
            try
            {
                value = int.Parse(param.Value == null || param.Value == "" ? "0" : param.Value);
            }
            catch (Exception e)
            {
                return Json(GetError(body.Id, new ErrorJson { Message = "Invalid params", Code = -3457 }, jsonrpc));

            }

            switch (method)
            {
                case "SetM": { result = SetM(key, value); break; }
                case "GetM": { result = GetM(key); break; }
                case "AddM": { result = AddM(key, value); break; }
                case "SubM": { result = SubM(key, value); break; }
                case "MulM": { result = MulM(key, value); break; }
                case "DivM": { result = DivM(key, value); break; }
                case "ErrorExit": { ErrorExit(); break; }

                default:
                    {
                        return Json(GetError(body.Id, new ErrorJson
                        {
                            Message = string.Format("Function {0} is not found", body.Method),
                            Code = -32601
                        }, jsonrpc));
                    }
            }

            return Json(new ResJsonRPC()
            {
                Id = body.Id,
                Jsonrpc = jsonrpc,
                Method = body.Method,
                Result = result
            }, JsonRequestBehavior.AllowGet
            );
        }

        private JsonRPCError GetError(string id, ErrorJson error, string jsonrpc)
        {
            return new JsonRPCError()
            {
                Id = id,
                Jsonrpc = jsonrpc,
                Error = error
            };
        }

        private int? SetM(string k, int x)
        {
            HttpContext.Session[k] = x;
            return GetM(k);
        }

        private int? GetM(string k)
        {
            object result = HttpContext.Session[k];
            if (result == null)
                return null;
            else
                return int.Parse(result.ToString());
        }

        private int? AddM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Session[k] = value == null ? x : value + x;
            return GetM(k);
        }

        private int? SubM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Session[k] = value == null ? x : value - x;
            return GetM(k);
        }

        private int? MulM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Session[k] = value == null ? x : value * x;
            return GetM(k);
        }

        private int? DivM(string k, int x)
        {
            int? value = GetM(k);
            HttpContext.Session[k] = value == null ? x : value / x;
            return GetM(k);
        }

        private void ErrorExit()
        {
            HttpContext.Session.Clear();
            HttpContext.Session["MethodsIgnore"] = true;
            ignoreMethods = true;
        }
    }
}