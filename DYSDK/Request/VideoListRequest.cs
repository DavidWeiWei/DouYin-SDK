using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Request
{
    /// <summary>
    /// 查询授权账号视频数据
    /// </summary>
    public class VideoListRequest:BaseRequest
    {
        public override string ApiName()
        {
            return "/video/list";
        }

        public override string RequestType()
        {
            return "GET";
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
        /// 分页游标, 默认传0。
        /// </summary>
        [JsonProperty("cursor")]
        public int Cursor { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
