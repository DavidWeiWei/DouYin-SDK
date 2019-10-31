using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Common
{
    public class DouYinClient
    {
        public const string BaseUrl = "https://open.douyin.com";

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        public string client_key { get; set; }

        /// <summary>
        /// client_secret
        /// </summary>
        public string client_secret { get; set; }

        public DouYinClient(string key,string secret)
        {
            this.client_key = key;
            this.client_secret = secret;
        }
    }
}
