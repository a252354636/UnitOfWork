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
    /// 实体-article_albums 
    /// </summary>
	public class article_albumsEntityTypeConfiguration :  EntityTypeConfiguration<article_albums>
    {
		public article_albumsEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 频道ID
        /// </summary>
        Property(s=>s.channel_id).IsOptional();
        /// <summary>
        /// 文章ID
        /// </summary>
        Property(s=>s.article_id).IsOptional();
        /// <summary>
        /// 缩略图地址
        /// </summary>
        Property(s=>s.thumb_path).IsOptional();
        /// <summary>
        /// 原图地址
        /// </summary>
        Property(s=>s.original_path).IsOptional();
        /// <summary>
        /// 图片描述
        /// </summary>
        Property(s=>s.remark).IsOptional();
        /// <summary>
        /// 上传时间
        /// </summary>
        Property(s=>s.add_time).IsOptional();
 
			//配置表名称
			ToTable("dt_article_albums");

		}
    }
}
