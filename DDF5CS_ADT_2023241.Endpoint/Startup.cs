using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Repository;
using Microsoft.EntityFrameworkCore;

namespace DDF5CS_ADT_2023241.Endpoint
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) { Configuration = configuration; }
        //Dependency Injection
        public void ConfigureServices(IServiceCollection services) {
            //Framework services
            services.AddControllers();
            //DbContext entity framework
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));

            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
            services.AddScoped<IRentInstanceRepository, RentInstanceRepository>();
            
            services.AddScoped<IBrandLogic, BrandLogic>();
            services.AddScoped<ICarModelLogic, CarModelLogic>();
            services.AddScoped<IRentInstanceLogic, RentInstanceLogic>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}