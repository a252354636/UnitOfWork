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
    /// 实体-article_tags 
    /// </summary>
	public class article_tagsEntityTypeConfiguration :  EntityTypeConfiguration<article_tags>
    {
		public article_tagsEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 标题
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 是否推荐
        /// </summary>
        Property(s=>s.is_red).IsOptional();
        /// <summary>
        /// 排序数字
        /// </summary>
        Property(s=>s.sort_id).IsOptional();
        /// <summary>
        /// 时间
        /// </summary>
        Property(s=>s.add_time).IsOptional();
 
			//配置表名称
			ToTable("dt_article_tags");

		}
    }
}
