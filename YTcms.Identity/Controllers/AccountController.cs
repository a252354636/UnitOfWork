﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YTcms.Identity.DataModels;
using YTcms.Identity.Services;

namespace YTcms.Identity.Controllers
{
    public class AccountController : Controller
    {
        private IAdminService _adminService;//自己写的操作数据库Admin表的service
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IClientStore _clientStore;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IEventService _events;
        public AccountController(IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events,
            IAdminService adminService)
        {
            _interaction = interaction;
            _clientStore = clientStore;
            _schemeProvider = schemeProvider;
            _events = events;
            _adminService = adminService;
        }

        /// <summary>
        /// 登录页面
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        /// <summary>
        /// 登录post回发处理
        /// </summary>
        [HttpPost]
        public async Task<HttpResponseMessage> Login(string userName, string password, string returnUrl = null)
        {
            ViewData["returnUrl"] = returnUrl;
            dt_users user = await _adminService.GetByStr(userName, password);
            var response = new HttpResponseMessage();
            response.Content = new StringContent("");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            response.Content.Headers.ContentType.CharSet = "utf-8";
            if (user != null)
            {
                AuthenticationProperties props = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.Add(TimeSpan.FromDays(1))
                };
                await HttpContext.SignInAsync(user.Id.ToString(), user.user_name, props);

                HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.Moved);
                resp.Headers.Location = new Uri("http://localhost:5002/" + returnUrl);
                return resp;
            }
            else
            {
                    response.Content = new StringContent("无效的订单id！");
                    return response;
            }
        }
    }
}