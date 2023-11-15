using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class BrandLogic : IBrandLogic
    {
        private readonly IBrandRepository _brandRepository;

        public BrandLogic(IBrandRepository brandRepository) { _brandRepository = brandRepository; }
        public IEnumerable<Brand> GetAllBrands() { return _brandRepository.GetAllBrands(); }
        public IEnumerable<CarModel> GetModelsForBrand(int brandId) { return _brandRepository.GetModelsForBrand(brandId); }
        public void CreateBrand(Brand brand) { _brandRepository.Create(brand); }
        public Brand? GetBrand(int id) { return _brandRepository.Read(id); }
        public void UpdateBrand(Brand brand) { _brandRepository.Update(brand); }
        public void DeleteBrand(int id) { _brandRepository.Delete(id); }
    }
}