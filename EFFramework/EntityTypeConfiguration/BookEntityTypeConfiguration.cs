﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFramework
{
  public class BookEntityTypeConfiguration : EntityTypeConfiguration<Book>
  {
    public BookEntityTypeConfiguration()
    {
      //配置主键
      HasKey(s => s.ID);

      //配置列
      Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
      Property(s => s.Uid).IsRequired();
      Property(p => p.Name).IsRequired();
      //配置表名称
      ToTable("Books");

    }
  }
}
