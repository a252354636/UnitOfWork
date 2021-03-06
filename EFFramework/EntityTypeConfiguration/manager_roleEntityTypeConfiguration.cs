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
    /// 实体-manager_role 
    /// </summary>
	public class manager_roleEntityTypeConfiguration :  EntityTypeConfiguration<manager_role>
    {
		public manager_roleEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 角色名称
        /// </summary>
        Property(s=>s.role_name).IsOptional();
        /// <summary>
        /// 角色类型
        /// </summary>
        Property(s=>s.role_type).IsOptional();
        /// <summary>
        /// 是否系统默认0否1是
        /// </summary>
        Property(s=>s.is_sys).IsOptional();
 
			//配置表名称
			ToTable("dt_manager_role");

		}
    }
}
