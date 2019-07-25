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
    /// 实体-dt_site_payment 
    /// </summary>
	public class site_payment :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 所属站点
        /// </summary>
         public int site_id{ get; set; }
        /// <summary>
        /// 支付方式ID
        /// </summary>
         public int payment_id{ get; set; }
        /// <summary>
        /// 自定义标题
        /// </summary>
         public string title{ get; set; }
        /// <summary>
        /// 通讯密钥1
        /// </summary>
         public string key1{ get; set; }
        /// <summary>
        /// 通讯密钥2
        /// </summary>
         public string key2{ get; set; }
        /// <summary>
        /// 通讯密钥3
        /// </summary>
         public string key3{ get; set; }
        /// <summary>
        /// 通讯密钥4
        /// </summary>
         public string key4{ get; set; }
        /// <summary>
        /// 排序数字
        /// </summary>
         public int sort_id{ get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
         public DateTime add_time{ get; set; }
 

	}
}