using JWT;
using JWT.Serializers;
using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace MvcApp.AuthAttributes
{
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //前端请求api时会将token存放在名为"auth"的请求头中
            var authHeader =  httpContext.Request.Headers.GetValues("auth");
            if (authHeader != null)
            {
                const string secretKey = "Hello World";//加密秘钥
                string token = authHeader.FirstOrDefault();//获取token
                if (!string.IsNullOrEmpty(token))
                {
                    try
                    {
                        byte[] key = Encoding.UTF8.GetBytes(secretKey);
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                        //解密
                        var json = decoder.DecodeToObject<AuthInfo>(token, key, verify: true);
                        if (json != null)
                        {
                            //判断口令过期时间
                            if (json.ExpiryDateTime < DateTime.Now)
                            {
                                return false;
                            }
                            httpContext.Response.AddHeader("auth", json.ToString());
                            return true;
                        }
                        return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        //protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        //{
        //    var erModel = new
        //    {
        //        Success = "false",
        //        ErrorCode = "401"
        //    };
        //    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, erModel, "application/json");
        //}

        //protected override bool IsAuthorized(HttpActionContext actionContext)
        //{
        //    //前端请求api时会将token存放在名为"auth"的请求头中
        //    var authHeader = from t in actionContext.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();
        //    if (authHeader != null)
        //    {
        //        const string secretKey = "Hello World";//加密秘钥
        //        string token = authHeader.FirstOrDefault();//获取token
        //        if (!string.IsNullOrEmpty(token))
        //        {
        //            try
        //            {
        //                byte[] key = Encoding.UTF8.GetBytes(secretKey);
        //                IJsonSerializer serializer = new JsonNetSerializer();
        //                IDateTimeProvider provider = new UtcDateTimeProvider();
        //                IJwtValidator validator = new JwtValidator(serializer, provider);
        //                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
        //                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
        //                //解密
        //                var json = decoder.DecodeToObject<AuthInfo>(token, key, verify: true);
        //                if (json != null)
        //                {
        //                    //判断口令过期时间
        //                    if (json.ExpiryDateTime < DateTime.Now)
        //                    {
        //                        return false;
        //                    }
        //                    actionContext.ActionArguments.Add("auth", json);
        //                    return true;
        //                }
        //                return false;
        //            }
        //            catch (Exception ex)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return false;
        //}
    }
}