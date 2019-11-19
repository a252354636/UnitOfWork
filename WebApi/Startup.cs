
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi;
using WebApi.OAuth;

[assembly: OwinStartup(typeof(MvcApp.OAuth.Startup))]
namespace MvcApp.OAuth
{
    public class Startup
    {

        //Provider ：提供具体的认证策略；
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            ConfigureOAuth(app);

            //这一行代码必须放在ConfiureOAuth(app)之后
            app.UseWebApi(config);
        }


        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new SimpleAuthorizationServerProvider(),

                //refresh token provider
                RefreshTokenProvider = new SimpleRefreshTokenProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            //ConfigureOAuth(IAppBuilder app)方法开启了OAuth服务。简单说一下OAuthAuthorizationServerOptions中各参数的含义：
            //AllowInsecureHttp：允许客户端使用http协议请求；
            //TokenEndpointPath：token请求的地址，即http://localhost:端口号/token；
            //AccessTokenExpireTimeSpan ：token过期时间；
            //Provider ：提供具体的认证策略；
        }
    }
}