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
    /// 实体-user_groups 
    /// </summary>
	public class user_groupsEntityTypeConfiguration :  EntityTypeConfiguration<user_groups>
    {
		public user_groupsEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 组别名称
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 会员等级值
        /// </summary>
        Property(s=>s.grade).IsOptional();
        /// <summary>
        /// 升级经验值
        /// </summary>
        Property(s=>s.upgrade_exp).IsOptional();
        /// <summary>
        /// 默认预存款
        /// </summary>
        Property(s=>s.amount).IsOptional();
        /// <summary>
        /// 默认积分
        /// </summary>
        Property(s=>s.point).IsOptional();
        /// <summary>
        /// 购物折扣
        /// </summary>
        Property(s=>s.discount).IsOptional();
        /// <summary>
        /// 是否注册用户组
        /// </summary>
        Property(s=>s.is_default).IsOptional();
        /// <summary>
        /// 是否自动升级
        /// </summary>
        Property(s=>s.is_upgrade).IsOptional();
        /// <summary>
        /// 是否禁用
        /// </summary>
        Property(s=>s.is_lock).IsOptional();
 
			//配置表名称
			ToTable("dt_user_groups");

		}
    }
}
