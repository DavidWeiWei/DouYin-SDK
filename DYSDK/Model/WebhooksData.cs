using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Model
{
    /// <summary>
    /// webhooks 消息结构实体
    /// </summary>
    public class WebhooksData
    {
        public string MsgId { get; set; }
        /// <summary>
        /// 时间名称
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// 用户 openid
        /// </summary>
        [JsonProperty("from_user_id")]
        public string FromUserId { get; set; }

        /// <summary>
        /// 用户 openid
        /// </summary>
        [JsonProperty("to_user_id")]
        public string ToUserId { get; set; }

        /// <summary>
        /// 应用 key
        /// </summary>
        [JsonProperty("client_key")]
        public string ClientKey { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("content")]
        public object Content { get; set; }
    }
}
