using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<ge_group>
    {
        public void Configure(EntityTypeBuilder<ge_group> builder)
        {
            builder
                .HasKey(m => m.Id);

            // builder
            //     .Property(m => m.Id)
            //     .UseIdentityColumn();
            // builder.HasOne(typeof(ge_user),"manager")
            // .WithMany()
            // .HasForeignKey("managerId")
            // .OnDelete(DeleteBehavior.Restrict);   

            // builder.HasOne(typeof(ge_user),"created")
            // .WithMany()
            // .HasForeignKey("createdId")
            // .OnDelete(DeleteBehavior.Restrict);    
            
            // builder.HasOne(typeof(ge_user),"edited")
            // .WithMany()
            // .HasForeignKey("editedId")
            // .OnDelete(DeleteBehavior.Restrict);   
            
            builder
                .Property(m => m.name)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .ToTable("ge_group");
        }
    }
}