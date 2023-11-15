using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace DDF5CS_ADT_2023241.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fetching Brands...");

            using var client = new HttpClient();

            // Adjust the base URL according to your API endpoint
            client.BaseAddress = new Uri("https://your-api-base-url.com/api/");

            HttpResponseMessage response = await client.GetAsync("Brand");

            if (response.IsSuccessStatusCode)
            {
                var brands = await response.Content.ReadFromJsonAsync<Brand[]>();

                // Check if brands is not null before accessing its members
                if (brands != null)
                {
                    foreach (var brand in brands)
                    {
                        // Use null-conditional operator to handle possible null references
                        Console.WriteLine($"Brand ID: {brand?.BrandId}, Name: {brand?.BrandName}");
                    }
                }
                else
                {
                    Console.WriteLine("No brands found.");
                }
            }
            else
            {
                Console.WriteLine($"Failed to fetch brands. Status code: {response.StatusCode}");
            }
        }
    }
}