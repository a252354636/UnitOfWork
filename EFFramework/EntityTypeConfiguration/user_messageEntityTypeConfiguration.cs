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
    /// 实体-user_message 
    /// </summary>
	public class user_messageEntityTypeConfiguration :  EntityTypeConfiguration<user_message>
    {
		public user_messageEntityTypeConfiguration()
		{
			/// <summary>
        /// 自增ID
        /// </summary>
        HasKey(s => s.id);
        Property(s=>s.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        /// <summary>
        /// 短信息类型0系统消息1收件箱2发件箱
        /// </summary>
        Property(s=>s.type).IsOptional();
        /// <summary>
        /// 发件人
        /// </summary>
        Property(s=>s.post_user_name).IsOptional();
        /// <summary>
        /// 收件人
        /// </summary>
        Property(s=>s.accept_user_name).IsOptional();
        /// <summary>
        /// 是否查看0未阅1已阅
        /// </summary>
        Property(s=>s.is_read).IsOptional();
        /// <summary>
        /// 短信息标题
        /// </summary>
        Property(s=>s.title).IsOptional();
        /// <summary>
        /// 短信息内容
        /// </summary>
        Property(s=>s.content).IsOptional();
        /// <summary>
        /// 发送时间
        /// </summary>
        Property(s=>s.post_time).IsRequired();
        /// <summary>
        /// 阅读时间
        /// </summary>
        Property(s=>s.read_time).IsOptional();
 
			//配置表名称
			ToTable("dt_user_message");

		}
    }
}
