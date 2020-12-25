using Microsoft.EntityFrameworkCore;
using ge_repository.data.configurations;
using ge_repository.core.models;

namespace ge_repository.data
{
    public class ge_DbContext : DbContext
    {
        public ge_DbContext(DbContextOptions<ge_DbContext> options)
                : base(options)
        {
        }
        public DbSet<ge_group> ge_group{get; set;}
        public DbSet<ge_user_ops> ge_user_ops { get; set; }
        public DbSet<ge_project> ge_project { get; set; }
        public DbSet<ge_user> ge_user { get; set; }
        public DbSet<ge_data> ge_data{ get;set;}
        public DbSet<ge_data_big> ge_data_big{ get;set;}
        public DbSet<ge_transform> ge_transform { get; set; }
        public DbSet<ge_event> ge_event { get; set; }
        public ge_user user { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            builder
                .ApplyConfiguration(new UserConfiguration());    
            
            builder
                .ApplyConfiguration(new UserOpsConfiguration());        
            
            builder
                .ApplyConfiguration(new DataConfiguration());
            
            builder
                .ApplyConfiguration(new TransformConfiguration());    

            builder
                .ApplyConfiguration(new ProjectConfiguration());
            
            builder
                .ApplyConfiguration(new GroupConfiguration());    

              
           base.OnModelCreating(builder);   
        }   
        

    }
}
