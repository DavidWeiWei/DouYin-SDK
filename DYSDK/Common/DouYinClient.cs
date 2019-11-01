using DYSDK.Dto;
using DYSDK.Request;
using DYSDK.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DYSDK.Common
{
    public class DouYinClient
    {
        public const string BaseUrl = "https://open.douyin.com";

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        public string Client_key { get; set; }

        /// <summary>
        /// client_secret
        /// </summary>
        public string Client_secret { get; set; }

        public DouYinClient(string key,string secret)
        {
            this.Client_key = key;
            this.Client_secret = secret;
        }

        #region 获取请求参数key=value的形式
        /// <summary>
        /// 获取请求类的keyValue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="notDeal"></param>
        /// <returns></returns>
        public string GetRequestKeyValue(BaseRequest request)
        {
            List<string> keyVals = new List<string>();
            Type type = request.GetType();
            var propList = type.GetProperties().OrderBy(x => x.Name.ToLower()).ToList();
            propList.ForEach(p =>
            {
                JsonPropertyAttribute attr = (JsonPropertyAttribute)p.GetCustomAttributes(typeof(JsonPropertyAttribute), true).FirstOrDefault();
                if (attr != null)
                {
                    string key = attr.PropertyName;
                    string value = string.Empty;
                    if (p.PropertyType.IsClass && p.PropertyType != typeof(String))
                    {
                        value = JsonConvert.SerializeObject(p.GetValue(request));
                    }
                    else
                    {
                        value = p.GetValue(request).ToString();
                    }
                    switch (key)
                    {
                        case "client_key":
                            value = Client_key;
                            break;
                        case "client_secret":
                            value = Client_secret;
                            break;
                    }
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        keyVals.Add(key + "=" + value);
                    }
                }
            });
            return string.Join("&", keyVals);
        }
        #endregion

        #region 向抖音发起请求
        /// <summary>
        /// 向抖音发起请求
        /// </summary>
        /// <typeparam name="Res"></typeparam>
        /// <param name="requestParam"></param>
        /// <returns></returns>
        public Res Execute<Res>(BaseRequest requestParam)
        {
            RestClient restClient = new RestClient(BaseUrl);
            string data = this.GetRequestKeyValue(requestParam);
            var request = new RestRequest(requestParam.ApiName() + "?" + data);
            if (requestParam.RequestType() == "Post")
            {
                request.Method = Method.POST;
            }
            else if(requestParam.RequestType() == "Get")
            {
                request.Method = Method.GET;
            }
            IRestResponse response = restClient.Execute(request);
            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                return JsonConvert.DeserializeObject<Res>(response.Content);
            }
            else
            {
                throw new Exception("Response.Content is null");
            }
        }
        #endregion

        #region 用户授权发起url
        /// <summary>
        /// 获取用户授权url
        /// </summary>
        /// <returns></returns>
        public string GetLogonAuthorizationUrl(string redirect_uri, string scope = "user_info")
        {
            string logonAuthorizationUrl = string.Empty;
            PlatformOauthConnectRequest request = new PlatformOauthConnectRequest()
            {
                Scope = scope
                ,
                RedirectURI = redirect_uri
            };

            return BaseUrl + request.ApiName() + GetRequestKeyValue(request);
        }
        #endregion

        #region 获取用户授权
        /// <summary>
        /// 获取用户的授权信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public OauthResponseData GetAccessToken(string code)
        {
            OauthAccessTokenRequest request = new OauthAccessTokenRequest()
            {
               Code = code
            };
            OauthAccessTokenResponse response = Execute<OauthAccessTokenResponse>(request);
            if (response.Code == "200")
            {
                return response.Description.Data;
            }
            else
            {
                throw new Exception("error code:"+response.Code);
            }
        }
        #endregion

        #region 刷新/续期用户授权
        /// <summary>
        /// 刷新/续期用户授权
        /// </summary>
        /// <param name="refresh_token"></param>
        /// <returns></returns>
        public OauthResponseData RefreshToken(string refresh_token)
        {
            OauthRefreshTokenRequest request = new OauthRefreshTokenRequest()
            {
                RefreshToken = refresh_token
            };

            OauthRefreshTokenResponse response = Execute<OauthRefreshTokenResponse>(request);
            if (response.Code == "200")
            {
                return response.Description.Data;
            }
            else
            {
                throw new Exception("error code:" + response.Code);
            }
        }
        #endregion
    }
}
