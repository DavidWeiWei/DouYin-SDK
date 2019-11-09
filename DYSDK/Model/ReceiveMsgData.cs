using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Model
{
    /// <summary>
    /// 接收私信消息 目前只对接文本消息
    /// </summary>
    public class ReceiveMsgData
    {
        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
