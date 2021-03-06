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
    /// 实体-navigation 
    /// </summary>
	public class navigationEntityTypeConfiguration :  EntityTypeConfiguration<navigation>
    {
		public navigationEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 所属父导航ID
        /// </summary>
        Property(s=>s.parent_id).IsOptional();
        /// <summary>
        /// 所属频道ID
        /// </summary>
        Property(s=>s.channel_id).IsOptional();
        /// <summary>
        /// 导航类别
        /// </summary>
        Property(s=>s.nav_type).IsOptional();
        /// <summary>
        /// 导航ID
        /// </summary>
        Property(s=>s.name).IsOptional();
        /// <summary>
        /// 标题
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 副标题
        /// </summary>
        Property(s=>s.sub_title).IsOptional();
        /// <summary>
        /// 图标地址
        /// </summary>
        Property(s=>s.icon_url).IsOptional();
        /// <summary>
        /// 链接地址
        /// </summary>
        Property(s=>s.link_url).IsOptional();
        /// <summary>
        /// 排序数字
        /// </summary>
        Property(s=>s.sort_id).IsOptional();
        /// <summary>
        /// 是否隐藏0显示1隐藏
        /// </summary>
        Property(s=>s.is_lock).IsOptional();
        /// <summary>
        /// 备注说明
        /// </summary>
        Property(s=>s.remark).IsOptional();
        /// <summary>
        /// 权限资源
        /// </summary>
        Property(s=>s.action_type).IsOptional();
        /// <summary>
        /// 系统默认
        /// </summary>
        Property(s=>s.is_sys).IsOptional();
 
			//配置表名称
			ToTable("dt_navigation");

		}
    }
}
