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
    /// 实体-manager_role_value 
    /// </summary>
	public class manager_role_valueEntityTypeConfiguration :  EntityTypeConfiguration<manager_role_value>
    {
		public manager_role_valueEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 角色ID
        /// </summary>
        Property(s=>s.role_id).IsOptional();
        /// <summary>
        /// 导航名称
        /// </summary>
        Property(s=>s.nav_name).IsOptional();
        /// <summary>
        /// 权限类型
        /// </summary>
        Property(s=>s.action_type).IsOptional();
 
			//配置表名称
			ToTable("dt_manager_role_value");

		}
    }
}
