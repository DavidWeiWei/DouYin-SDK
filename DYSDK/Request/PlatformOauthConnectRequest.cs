using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Request
{
    /// <summary>
    /// /platform/oauth/connect/
    /// </summary>
    public class PlatformOauthConnectRequest: BaseGetRequest
    {
        public override string ApiName()
        {
            return "/platform/oauth/connect/";
        }

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonProperty("client_key")]
        public string ClientKey { get; set; }

        /// <summary>
        /// 填写code
        /// </summary>
        [JsonProperty("response_type")]
        public string ResponseType {
            get
            {
                return "code";
            }
        }

        /// <summary>
        /// 应用授权作用域,多个授权作用域以英文逗号（,）分隔
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 授权成功后的回调地址，必须以http/https开头。
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string RedirectURI { get; set; }

        /// <summary>
        /// 用于保持请求和回调的状态
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
