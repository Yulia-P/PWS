using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_8.Models
{
    public class Data
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class ErrorJson
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
    public class ReqJsonRPC
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public string Method { get; set; }
        public Data Params { get; set; }
    }
    public class ResJsonRPC
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public string Method { get; set; }
        public int? Result { get; set; }
    }
    public class JsonRPCError
    {
        public string Jsonrpc { get; set; }
        public ErrorJson Error { get; set; }
        public string Id { get; set; }
    }
}