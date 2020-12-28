using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<ge_project>
    {
        public void Configure(EntityTypeBuilder<ge_project> builder)
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
                .HasMaxLength(255);

            builder
                .HasOne(m => m.group)
                .WithMany(a => a.projects)
                .HasForeignKey(m => m.groupId);

            builder
                .ToTable("ge_project");
        }
    }
}