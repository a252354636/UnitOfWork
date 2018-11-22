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
    public class UsersEntityTypeConfiguration : EntityTypeConfiguration<Users>
    {
        public UsersEntityTypeConfiguration()
        {
            HasKey(s => s.ID);
            Property(s => s.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name).IsOptional();
            ToTable("Users");
        }
    }
}
