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
    /// 实体-dt_link 
    /// </summary>
	public class link :  IBaseEntity
	{
   
			/// <summary>
        /// 
        /// </summary>
         public int id{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int site_id{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string title{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string user_name{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string user_tel{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string email{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string site_url{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string img_url{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int is_image{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int sort_id{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public byte is_red{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public byte is_lock{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public DateTime? add_time{ get; set; }
 

	}
}
