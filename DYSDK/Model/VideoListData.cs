using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Model
{
    /// <summary>
    /// 视频数据list
    /// </summary>
    public class VideoListData:BaseData
    {
        [JsonProperty("list")]
        public  List<VideoData> List { get; set; }
    }

    /// <summary>
    /// 视频数据list
    /// </summary>
    public class VideoData
    {
        /// <summary>
        /// 视频id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 视频标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 视频封面
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        [JsonProperty("is_top")]
        public bool IsTop { get; set; }

        /// <summary>
        /// 视频创建时间戳
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 是否审核通过
        /// </summary>
        [JsonProperty("is_reviewed")]
        public bool IsReviewed { get; set; }

        /// <summary>
        /// 视频播放页面
        /// </summary>
        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 视频统计数据
        /// </summary>
        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }
    }

    /// <summary>
    /// 视频相关统计数据
    /// </summary>
    public class Statistics {
        /// <summary>
        /// 评论数
        /// </summary>
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("digg_count")]
        public int DiggCount { get; set; }

        /// <summary>
        /// 下载数
        /// </summary>
        [JsonProperty("download_count")]
        public int DownloadCount { get; set; }

        /// <summary>
        /// 播放数
        /// </summary>
        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        /// <summary>
        /// 分享数
        /// </summary>
        [JsonProperty("share_count")]
        public int ShareCount { get; set; }

        /// <summary>
        /// 转发数
        /// </summary>
        [JsonProperty("forward_count")]
        public int ForwardCount { get; set; }
    }
}
