using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Response
{
    /// <summary>
    /// 响应基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
