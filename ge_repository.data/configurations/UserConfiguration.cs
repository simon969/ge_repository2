using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ge_user>
    {
        public void Configure(EntityTypeBuilder<ge_user> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            
            builder
                .Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(255);
            
            builder
                .ToTable("ge_user");
        }
    }
}