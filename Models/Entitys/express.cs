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
    /// 实体-dt_express 
    /// </summary>
	public class express :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 快递名称
        /// </summary>
         public string title{ get; set; }
        /// <summary>
        /// 物流编码
        /// </summary>
         public string express_code{ get; set; }
        /// <summary>
        /// 配送费用
        /// </summary>
         public decimal? express_fee{ get; set; }
        /// <summary>
        /// 快递网址
        /// </summary>
         public string website{ get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
         public string remark{ get; set; }
        /// <summary>
        /// 排序
        /// </summary>
         public int? sort_id{ get; set; }
        /// <summary>
        /// 是否不显示
        /// </summary>
         public byte? is_lock{ get; set; }
 

	}
}
