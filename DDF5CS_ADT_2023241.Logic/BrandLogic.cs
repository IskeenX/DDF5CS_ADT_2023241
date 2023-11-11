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

        public BrandLogic(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void CreateBrand(Brand brand)
        {
            // Implement error handling, validation, etc.
            _brandRepository.Create(brand);
        }
        public Brand GetBrand(int id)
        {
            return _brandRepository.Read(id);
        }
        public IEnumerable<Brand> GetAllBrands()
        {
            return _brandRepository.ReadAll();
        }
        public void UpdateBrand(Brand brand)
        {
            // Implement error handling, validation, etc.
            _brandRepository.Update(brand);
        }
        public void DeleteBrand(int id)
        {
            _brandRepository.Delete(id);
        }
        public IEnumerable<CarModel> GetModelsForBrand(int brandId)
        {
            // Implement logic to retrieve models for a brand
            throw new NotImplementedException();
        }
        public IEnumerable<RentInstance> GetRentInstancesForBrand(int brandId)
        {
            // Implement logic to retrieve rent instances for a brand
            throw new NotImplementedException();
        }
    }
}