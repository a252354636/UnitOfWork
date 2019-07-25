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
    /// 实体-channel_article_goods 
    /// </summary>
	public class channel_article_goodsEntityTypeConfiguration :  EntityTypeConfiguration<channel_article_goods>
    {
		public channel_article_goodsEntityTypeConfiguration()
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
        Property(s=>s.channel_id).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.category_id).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.call_index).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.link_url).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.img_url).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.seo_title).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.seo_keywords).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.seo_description).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.tags).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.zhaiyao).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.content).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.sort_id).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.click).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.status).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_msg).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_top).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_red).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_hot).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_slide).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.is_sys).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.user_name).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.like_count).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.add_time).IsRequired();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.update_time).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.sub_title).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.goods_no).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.stock_quantity).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.market_price).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.sell_price).IsOptional();
        /// <summary>
        /// 
        /// </summary>
        Property(s=>s.point).IsOptional();
 
			//配置表名称
			ToTable("dt_channel_article_goods");

		}
    }
}
