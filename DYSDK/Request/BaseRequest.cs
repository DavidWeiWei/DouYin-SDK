using System;
using System.Collections.Generic;
using System.Text;

namespace DYSDK.Request
{
    public abstract class BaseRequest
    {
        /// <summary>
        /// api路径
        /// </summary>
        public abstract string ApiName();

        /// <summary>
        /// api请求类型 Post/Get
        /// Post 类型中 JsonProperty order = 0 表示拼接到 url  order = 1 表示拼接到 body
        /// </summary>
        /// <returns></returns>
        public abstract string RequestType();
    }
}
