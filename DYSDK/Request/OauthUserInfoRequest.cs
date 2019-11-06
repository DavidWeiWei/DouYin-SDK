using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Request
{
    /// <summary>
    /// 获取用户的抖音公开信息，包含昵称、头像、性别和地区。
    /// </summary>
    public class OauthUserInfoRequest : BaseGetRequest
    {
        public override string ApiName()
        {
            return "/oauth/userinfo";
        }

        /// <summary>
        /// 用户授权token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户在当前应用的唯一标识
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }
    }
}
