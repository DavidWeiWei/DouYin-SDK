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
        /// api请求类型 POST/GET
        /// </summary>
        /// <returns></returns>
        public abstract string RequestType();
    }
}
