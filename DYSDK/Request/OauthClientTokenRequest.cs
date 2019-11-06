using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    /// <summary>
    /// 生成 client_token
    /// </summary>
    public class OauthClientTokenRequest : BaseGetRequest
    {
        public override string ApiName()
        {
            return "/oauth/client_token";
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
        /// 填写client_credential
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType {
            get
            {
                return "client_credential";
            }
        }
    }
}
