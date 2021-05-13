using AppWebNeo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebNeo.Infra.Data.Configuration
{
    public class ContatosMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder
                .HasKey(v => v.Id);

            //builder.ToTable("tblContato");
        }
    }
}
