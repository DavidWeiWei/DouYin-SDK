using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Response
{
    public class BaseResponse<T> where T: class
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public T Description { get; set; }

        [JsonProperty("Links")]
        public string Links { get; set; }
    }
}
