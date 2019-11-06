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
    }

    /// <summary>
    /// Get基础请求类
    /// </summary>
    public abstract class BaseGetRequest: BaseRequest
    {
    }

    /// <summary>
    /// post请求基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BasePostRequest: BaseRequest
    {
        /// <summary>
        /// 用于传输实体类 json数据格式化
        /// </summary>
        public abstract string BodyData();
    }
}
