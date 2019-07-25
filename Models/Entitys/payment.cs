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
    /// 实体-dt_payment 
    /// </summary>
	public class payment :  IBaseEntity
	{
   
			/// <summary>
        /// 自增ID
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 支付名称
        /// </summary>
         public string title{ get; set; }
        /// <summary>
        /// 显示图片
        /// </summary>
         public string img_url{ get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
         public string remark{ get; set; }
        /// <summary>
        /// 支付类型1线上2线下
        /// </summary>
         public byte? type{ get; set; }
        /// <summary>
        /// 手续费类型1百分比2固定金额
        /// </summary>
         public byte? poundage_type{ get; set; }
        /// <summary>
        /// 手续费金额
        /// </summary>
         public decimal? poundage_amount{ get; set; }
        /// <summary>
        /// API目录名
        /// </summary>
         public string api_path{ get; set; }
        /// <summary>
        /// 支付链接页面
        /// </summary>
         public string redirect_url{ get; set; }
        /// <summary>
        /// 跳转返回页面
        /// </summary>
         public string return_url{ get; set; }
        /// <summary>
        /// 支付通知页面
        /// </summary>
         public string notify_url{ get; set; }
        /// <summary>
        /// 排序
        /// </summary>
         public int? sort_id{ get; set; }
        /// <summary>
        /// 是否启用0正常1禁用
        /// </summary>
         public byte? is_lock{ get; set; }
 

	}
}
