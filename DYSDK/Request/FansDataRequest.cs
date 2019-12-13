using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    public class FansDataRequest :BaseGetRequest
    {
        public override string ApiName()
        {
            return "/fans/data/";
        }

        /// <summary>
        /// 如果是client_access_token, 则不需要传open_id。操作用户数据的接口都需要传入open_id。
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户授权token  
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
