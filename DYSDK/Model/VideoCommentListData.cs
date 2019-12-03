 using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Model
{
    public class VideoCommentListData:BaseData
    {
        [JsonProperty("list")]
        public List<VideoCommentData> List { get; set; }
    }

    public class VideoCommentData
    {
        /// <summary>
        /// 评论id
        /// </summary>
        [JsonProperty("comment_id")]
        public string CommentId { get; set; }

        /// <summary>
        /// 评论的用户id
        /// </summary>
        [JsonProperty("comment_user_id")]
        public string CommentUserId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// 是否置顶评论
        /// </summary>
        [JsonProperty("top")]
        public bool Top { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        [JsonProperty("digg_count")]
        public int DiggCount { get; set; }

        /// <summary>
        /// 回复评论数
        /// </summary>
        [JsonProperty("reply_comment_total")]
        public int ReplyCommentTotal { get; set; }
    }
}
