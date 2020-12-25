using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class UserOpsConfiguration : IEntityTypeConfiguration<ge_user_ops>
    {
        public void Configure(EntityTypeBuilder<ge_user_ops> builder)
        {
            builder
                .HasKey(m => m.Id);
            
            // builder.HasOne(typeof(ge_user),"created")
            // .WithMany()
            // .HasForeignKey("createdId")
            // .OnDelete(DeleteBehavior.Restrict);    
            
            // builder.HasOne(typeof(ge_user),"edited")
            // .WithMany()
            // .HasForeignKey("editedId")
            // .OnDelete(DeleteBehavior.Restrict);   
            builder
                .ToTable("ge_user_ops");
        }
    }
}