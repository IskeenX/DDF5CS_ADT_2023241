using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Repository;
using Microsoft.EntityFrameworkCore;

namespace DDF5CS_ADT_2023241.Endpoint
{
    public class Startup
    {
        //Dependency Injection
        public void ConfigureServices(IServiceCollection services)
        {
            //Other configurations...
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));

            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
            services.AddScoped<IRentInstanceRepository, RentInstanceRepository>();
            
            services.AddScoped<IBrandLogic, BrandLogic>();
            services.AddScoped<ICarModelLogic, CarModelLogic>();
            services.AddScoped<IRentInstanceLogic, RentInstanceLogic>();
            
            //Other configurations...
        }
    }
}