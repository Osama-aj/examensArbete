using System.Collections.Generic;
using Newtonsoft.Json;

namespace examensArbete.Models
{
    public class ExceptionFirebase
    {
        [JsonProperty("Response")]
        public Response Response { get; set; }
    }
    public class Response
    {
        [JsonProperty("error")]
        public ResponseError Error { get; set; }
    }
    public class ResponseError
    {
        [JsonProperty("code")]
        public long Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("errors")]
        public List<ErrorElement> Errors { get; set; }
    }
    public class ErrorElement
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("domain")]
        public string Domain { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
