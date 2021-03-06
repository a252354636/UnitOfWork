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
    /// 实体-dt_user_recharge 
    /// </summary>
	public class user_recharge :  IBaseEntity
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
        /// 充值单号
        /// </summary>
         public string recharge_no{ get; set; }
        /// <summary>
        /// 支付方式ID
        /// </summary>
         public int? payment_id{ get; set; }
        /// <summary>
        /// 金额
        /// </summary>
         public decimal? amount{ get; set; }
        /// <summary>
        /// 状态0未完成1已完成
        /// </summary>
         public byte? status{ get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
         public DateTime? add_time{ get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
         public DateTime? complete_time{ get; set; }
 

	}
}
