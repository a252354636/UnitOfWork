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
    /// 实体-dt_manager_log 
    /// </summary>
	public class manager_log :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
         public int user_id{ get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
         public string user_name{ get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
         public string action_type{ get; set; }
        /// <summary>
        /// 备注
        /// </summary>
         public string remark{ get; set; }
        /// <summary>
        /// 用户IP
        /// </summary>
         public string user_ip{ get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
         public DateTime add_time{ get; set; }
 

	}
}
