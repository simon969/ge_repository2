using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ge_repository.core;
using ge_repository.core.services;
using ge_repository.data;
using ge_repository.services;

namespace ge_repository.api
{
    public class Startup
    {
        public Startup(IWebHostEnvironment environment, IConfiguration configuration)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllers(); 
            services.AddDbContext<ge_DbContext>(
                                    options => options.UseSqlServer(Configuration.GetConnectionString("ge_DbContext"), 
                                    x => x.MigrationsAssembly("ge_repository.data"))
                                    );
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDataService, DataService>();
            services.AddTransient<IProjectService, ProjectService>();
         //   services.AddTransient<IGroupService, GroupService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ge_repository.api", Version = "v1" });
            });
			
			services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                        c.RoutePrefix = "";
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ge_repository.api v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
