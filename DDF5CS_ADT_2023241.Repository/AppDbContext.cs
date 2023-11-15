using DDF5CS_ADT_2023241.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<RentInstance> RentInstances {  get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Brand>()
                .HasMany(b => b.CarModels)
                .WithOne(cm => cm.Brand)
                .HasForeignKey(cm => cm.BrandId);
            modelBuilder.Entity<CarModel>()
                .HasMany(cm => cm.RentInstances)
                .WithOne(ri => ri.CarModel)
                .HasForeignKey(ri => ri.CarModelId);
            modelBuilder.Entity<RentInstance>()
                .HasOne(r => r.CarModel)
                .WithMany()
                .HasForeignKey(r => r.CarModelId);
            modelBuilder.Entity<Brand>().HasData(
                    new Brand { BrandId = 1, BrandName = "Brand1"},
                    new Brand { BrandId = 2, BrandName = "Brand2"} );
            modelBuilder.Entity<CarModel>().HasData(
                    new CarModel { CarModelId = 1, ModelName = "Model1", BrandId = 1},
                    new CarModel { CarModelId = 2, ModelName = "Model2", BrandId = 2} );
            modelBuilder.Entity<RentInstance>().HasData(
                    new RentInstance { RentInstanceId = 1, RentDate = DateTime.Now, CarModelId = 1},
                    new RentInstance { RentInstanceId = 2, RentDate = DateTime.Now, CarModelId = 2} );
        }       
    }
}