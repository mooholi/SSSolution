﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Mappings
{
    internal class ClienteMapConfig : EntityTypeConfiguration<ClienteDTO>
    {
        public ClienteMapConfig()
        {
            this.ToTable("CLIENTES");
            
            this.Property(c => c.CPF).IsRequired().IsFixedLength().HasMaxLength(14).IsUnicode(false);
            
            this.HasIndex(c => c.CPF).IsUnique();
            
            this.Property(c => c.DataNascimento).IsRequired().HasColumnType("date");
            
            this.Property(c => c.Email).HasMaxLength(60);
            
            this.Property(c => c.Nome).HasMaxLength(50);

            this.Property(c => c.Senha).HasMaxLength(30);
        }
    }
}
