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
    /// 实体-dt_manager 
    /// </summary>
	public class manager :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
         public int role_id{ get; set; }
        /// <summary>
        /// 管理员类型1超管2系管
        /// </summary>
         public int role_type{ get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
         public string user_name{ get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
         public string password{ get; set; }
        /// <summary>
        /// 6位随机字符串,加密用到
        /// </summary>
         public string salt{ get; set; }
        /// <summary>
        /// 管理员头像
        /// </summary>
         public string avatar{ get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
         public string real_name{ get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
         public string telephone{ get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
         public string email{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public byte is_audit{ get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
         public int is_lock{ get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
         public DateTime add_time{ get; set; }
 

	}
}
