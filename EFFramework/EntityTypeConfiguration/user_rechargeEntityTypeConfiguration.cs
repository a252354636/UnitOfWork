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
    /// 实体-user_recharge 
    /// </summary>
	public class user_rechargeEntityTypeConfiguration :  EntityTypeConfiguration<user_recharge>
    {
		public user_rechargeEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 用户ID
        /// </summary>
        Property(s=>s.user_id).IsOptional();
        /// <summary>
        /// 用户名
        /// </summary>
        Property(s=>s.user_name).IsOptional();
        /// <summary>
        /// 充值单号
        /// </summary>
        Property(s=>s.recharge_no).IsOptional();
        /// <summary>
        /// 支付方式ID
        /// </summary>
        Property(s=>s.payment_id).IsOptional();
        /// <summary>
        /// 金额
        /// </summary>
        Property(s=>s.amount).IsOptional();
        /// <summary>
        /// 状态0未完成1已完成
        /// </summary>
        Property(s=>s.status).IsOptional();
        /// <summary>
        /// 生成时间
        /// </summary>
        Property(s=>s.add_time).IsOptional();
        /// <summary>
        /// 完成时间
        /// </summary>
        Property(s=>s.complete_time).IsOptional();
 
			//配置表名称
			ToTable("dt_user_recharge");

		}
    }
}
