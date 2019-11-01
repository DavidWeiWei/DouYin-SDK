using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Response
{
    public class BaseResponse<T> where T: class
    {
        /// <summary>
        /// 消息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
