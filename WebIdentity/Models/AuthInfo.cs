﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIdentity.Models
{
    public class AuthInfo
    { /// <summary>
      /// 用户名
      /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public List<string> Roles { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 口令过期时间
        /// </summary>
        public DateTime? ExpiryDateTime { get; set; }
    }
}