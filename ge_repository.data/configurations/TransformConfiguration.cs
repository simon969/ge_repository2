using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class TransformConfiguration : IEntityTypeConfiguration<ge_transform>
    {
        public void Configure(EntityTypeBuilder<ge_transform> builder)
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
                .ToTable("ge_transform");
        }
    }
}