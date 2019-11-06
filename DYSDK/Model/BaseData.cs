using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Model
{
    public class BaseData
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误码描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 用于下一页请求的cursor
        /// </summary>
        [JsonProperty("cursor")]
        public long Cursor { get; set; }

        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
}
