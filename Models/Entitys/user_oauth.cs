//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace Models
{   
    /// <summary>
    /// 实体-dt_user_oauth 
    /// </summary>
	public class user_oauth :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
         public int? user_id{ get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
         public string user_name{ get; set; }
        /// <summary>
        /// 开放平台名称
        /// </summary>
         public string oauth_name{ get; set; }
        /// <summary>
        /// access_token
        /// </summary>
         public string oauth_access_token{ get; set; }
        /// <summary>
        /// 授权key
        /// </summary>
         public string oauth_openid{ get; set; }
        /// <summary>
        /// 授权时间
        /// </summary>
         public DateTime? add_time{ get; set; }
 

	}
}
