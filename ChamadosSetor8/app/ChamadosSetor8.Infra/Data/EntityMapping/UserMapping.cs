using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace ChamadosSetor8.Infra.Data.EntityMapping
{
    public  class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(c => c.CreationDate).IsRequired();

            builder.Property(g => g.Name).IsRequired();

            builder.Property(c => c.EmailAddress).IsRequired();

        }
    }
}