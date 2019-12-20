using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIdentity.Models
{
    public class Login
    {/// <summary>
     /// 用户名
     /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}