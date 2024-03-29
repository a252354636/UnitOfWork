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
    /// 实体-user_code 
    /// </summary>
	public class user_codeEntityTypeConfiguration :  EntityTypeConfiguration<user_code>
    {
		public user_codeEntityTypeConfiguration()
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
        /// 生成码类别 password取回密码,register邀请注册
        /// </summary>
        Property(s=>s.type).IsOptional();
        /// <summary>
        /// 生成的字符串
        /// </summary>
        Property(s=>s.str_code).IsOptional();
        /// <summary>
        /// 使用次数
        /// </summary>
        Property(s=>s.count).IsOptional();
        /// <summary>
        /// 状态0未使用1已使用
        /// </summary>
        Property(s=>s.status).IsOptional();
        /// <summary>
        /// 用户IP
        /// </summary>
        Property(s=>s.user_ip).IsOptional();
        /// <summary>
        /// 有效时间
        /// </summary>
        Property(s=>s.eff_time).IsRequired();
        /// <summary>
        /// 生成时间
        /// </summary>
        Property(s=>s.add_time).IsRequired();
 
			//配置表名称
			ToTable("dt_user_code");

		}
    }
}
