//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace EFFramework
{   
    /// <summary>
    /// 实体-site_payment 
    /// </summary>
	public class site_paymentEntityTypeConfiguration :  EntityTypeConfiguration<site_payment>
    {
		public site_paymentEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 所属站点
        /// </summary>
        Property(s=>s.site_id).IsOptional();
        /// <summary>
        /// 支付方式ID
        /// </summary>
        Property(s=>s.payment_id).IsOptional();
        /// <summary>
        /// 自定义标题
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 通讯密钥1
        /// </summary>
        Property(s=>s.key1).IsOptional();
        /// <summary>
        /// 通讯密钥2
        /// </summary>
        Property(s=>s.key2).IsOptional();
        /// <summary>
        /// 通讯密钥3
        /// </summary>
        Property(s=>s.key3).IsOptional();
        /// <summary>
        /// 通讯密钥4
        /// </summary>
        Property(s=>s.key4).IsOptional();
        /// <summary>
        /// 排序数字
        /// </summary>
        Property(s=>s.sort_id).IsOptional();
        /// <summary>
        /// 添加时间
        /// </summary>
        Property(s=>s.add_time).IsOptional();
 
			//配置表名称
			ToTable("dt_site_payment");

		}
    }
}
