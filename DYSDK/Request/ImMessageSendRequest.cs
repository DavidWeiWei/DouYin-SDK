using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    /// <summary>
    /// 给抖音用户发送消息
    /// </summary>
    public class ImMessageSendRequest : BasePostRequest
    {
        public override string ApiName()
        {
            return "/im/message/send/";
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

        public ImMessageSendRequestBody JsonData { get; set; }
    }

    /// <summary>
    /// body 数据
    /// </summary>
    public class ImMessageSendRequestBody
    {
        /// <summary>
        /// 发送消息的接收方openid
        /// </summary>
        [JsonProperty("to_user_id")]
        public string ToUserId { get; set; }

        /// <summary>
        /// 消息内容格式   text - 文本消息 / image - 图片消息
        /// </summary>
        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 文本内容 或 素材id
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
