using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DDF5CS_ADT_2023241.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CRUD Application Starting...");

            // Set up DbContextOptions for an in-memory database
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "YourDatabaseName")
                .Options;

            // Initialize AppDbContext with the provided options
            using var dbContext = new AppDbContext(options);

            // Your application logic or initialization here

            // Create an instance of BrandLogic and call a method
            var brandLogic = new BrandLogic(new BrandRepository(dbContext));
            var allBrands = brandLogic.GetAllBrands();

            foreach (var brand in allBrands)
            {
                Console.WriteLine($"Brand: {brand.BrandName}");
                // You can perform further operations with the retrieved brands here
            }

            Console.WriteLine("CRUD Application Ended...");
        }
    }
}