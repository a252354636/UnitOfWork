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
    /// 实体-feedback 
    /// </summary>
	public class feedbackEntityTypeConfiguration :  EntityTypeConfiguration<feedback>
    {
		public feedbackEntityTypeConfiguration()
		{
			/// <summary>
        /// 
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.site_id).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.content).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.user_name).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.user_tel).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.user_qq).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.user_email).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.add_time).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.reply_content).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.reply_time).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_lock).IsRequired();
 
			//配置表名称
			ToTable("dt_feedback");

		}
    }
}
