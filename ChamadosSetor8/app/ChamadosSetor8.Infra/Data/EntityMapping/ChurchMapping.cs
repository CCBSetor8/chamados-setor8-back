using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.EntityConfiguration
{
    public class ChurchMapping : IEntityTypeConfiguration<Church>
    {
        public void Configure(EntityTypeBuilder<Church> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CreationDate).IsRequired();

            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.Description).IsRequired();
        }
    }
}