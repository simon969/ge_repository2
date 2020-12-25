using ge_repository.core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ge_repository.data.configurations
{
    public class DataConfiguration : IEntityTypeConfiguration<ge_data>
    {
        public void Configure(EntityTypeBuilder<ge_data> builder)
        {
            builder
                .HasKey(m => m.Id);

            // builder
            //     .Property(m => m.Id)
            //     .UseIdentityColumn();
                
            builder
                .Property(m => m.filename)
                .IsRequired()
                .HasMaxLength(255);
            
            // builder.HasOne(typeof(ge_user),"created")
            // .WithMany()
            // .HasForeignKey("createdId")
            // .OnDelete(DeleteBehavior.Restrict);    
            
            // builder.HasOne(typeof(ge_user),"edited")
            // .WithMany()
            // .HasForeignKey("editedId")
            // .OnDelete(DeleteBehavior.Restrict);   
            
            builder
                .HasOne(m => m.project)
                .WithMany(a => a.data)
                .HasForeignKey(m => m.projectId);
                
            builder
                .HasOne(p => p.data)
                .WithOne(p => p.data)
                .HasForeignKey<ge_data>(p => p.Id);

            builder
                .ToTable("ge_data");
        }
    }

    public class DataBigConfiguration : IEntityTypeConfiguration<ge_data_big>
    {
        public void Configure(EntityTypeBuilder<ge_data_big> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
                
            builder
                .HasOne(p => p.data)
                .WithOne(p => p.data)
                .HasForeignKey<ge_data_big>(p => p.Id);  
            
            builder
                .ToTable("ge_data");
        }
    }
}