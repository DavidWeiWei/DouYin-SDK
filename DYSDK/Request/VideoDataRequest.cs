using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    /// <summary>
    /// 批量获取视频数据信息
    /// </summary>
    public class VideoDataRequest : BasePostRequest
    {
        public override string ApiName()
        {
            return "/video/data/";
        }

        public override string BodyData()
        {
            return JsonConvert.SerializeObject(JsonData);
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

        /// <summary>
        /// jons数据实体
        /// </summary>
        public VideoDataRequestBody JsonData { get; set; }
    }

    /// <summary>
    /// 用增加body发送数据
    /// </summary>
    public class VideoDataRequestBody
    {
        /// <summary>
        /// 要批量查询的视频ID
        /// </summary>
        [JsonProperty("item_ids")]
        public List<string> ItemIds { get; set; }
    }
}
