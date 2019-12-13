using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    public class VideoCommentReplyRequest : BasePostRequest
    {
        public override string ApiName()
        {
            return "/video/comment/reply/";
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

        public VideoCommentReplyRequestBody JsonData { get; set; }
    }

    public class VideoCommentReplyRequestBody
    {
        /// <summary>
        /// 视频id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 需要回复的评论id
        /// </summary>
        [JsonProperty("comment_id")]
        public string CommentId { get; set; }

        /// <summary>
        /// 评论内容 最长100
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }

}
