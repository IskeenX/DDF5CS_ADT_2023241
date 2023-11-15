using DDF5CS_ADT_2023241.Models;
using DDF5CS_ADT_2023241.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext _dbContext;

        public BrandRepository(AppDbContext dbContext) { _dbContext = dbContext; }
        public IEnumerable<Brand> GetAllBrands() { return _dbContext.Brands.ToList(); }
        public IEnumerable<CarModel> GetModelsForBrand(int brandId) { return _dbContext.CarModels.Where(c => c.BrandId == brandId).ToList(); }
        public void Create(Brand brand) {
            _dbContext.Brands.Add(brand);
            _dbContext.SaveChanges();
        }
        public Brand? Read(int id) { return _dbContext.Brands.Find(id); }
        public IQueryable<Brand> ReadAll() { return _dbContext.Brands.AsQueryable(); }
        public void Update(Brand brand) {
            _dbContext.Brands.Update(brand);
            _dbContext.SaveChanges();
        }
        public void Delete(int id) {
            var brand = _dbContext.Brands.Find(id);
            if(brand != null) {
                _dbContext.Brands.Remove(brand);
                _dbContext.SaveChanges();
            }
        }
    }
}