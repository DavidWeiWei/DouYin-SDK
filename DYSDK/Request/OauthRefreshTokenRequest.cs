using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    /// <summary>
    /// /oauth/refresh_token/
    /// </summary>
    public class OauthRefreshTokenRequest : BaseRequest
    {
        public override string ApiName()
        {
            return "/oauth/refresh_token/";
        }

        public override string RequestType()
        {
            return "Get";
        }

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonProperty("client_key")]
        public string ClientKey { get; set; }

        /// <summary>
        /// 填refresh_token
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType
        {
            get
            {
                return "refresh_token";
            }
        }

        /// <summary>
        /// 填写通过access_token获取到的refresh_token参数
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
