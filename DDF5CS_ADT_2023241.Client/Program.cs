using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DDF5CS_ADT_2023241.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
            {
                // Add necessary services for your console application
                services.AddTransient< IAPIInteractionService, APIInteractionService>();
                // Add other services related to your application

                // Perform API interactions in the Main method
                using var serviceScope = services.BuildServiceProvider().CreateScope();
                var apiInteractionService = serviceScope.ServiceProvider.GetRequiredService<IAPIInteractionService>();

                /*// Example interaction with the API service
                var result = myService.CallAPIMethod();
                Console.WriteLine(result); // Display the result or handle it accordingly*/

                // Example: Fetch data from API and display it in the console
                var dataFromAPI = apiInteractionService.FetchDataFromAPI();
                Console.WriteLine("Data from API:");
                Console.WriteLine(dataFromAPI);

            });
    }

    public interface IAPIInteractionService
    {
        string FetchDataFromAPI();
    }

    public class APIInteractionService : IAPIInteractionService
    {
        public string FetchDataFromAPI()
        {
            return "Data from the API";
        }
    }
}