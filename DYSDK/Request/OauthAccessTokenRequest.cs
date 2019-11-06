using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    /// <summary>
    /// 获取access_token
    /// </summary>
    public class OauthAccessTokenRequest : BaseGetRequest
    {
        public override string ApiName()
        {
            return "/oauth/access_token";
        }

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonProperty("client_key")]
        public string ClientKey { get; set; }

        /// <summary>
        /// 应用唯一标识对应的密钥
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 填写authorization_code
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get
            {
                return "authorization_code";
            }
        }
    }
}
