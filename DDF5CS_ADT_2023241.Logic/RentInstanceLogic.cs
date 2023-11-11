using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class RentInstanceLogic : IRentInstanceLogic
    {
        private readonly IRentInstanceRepository _rentInstanceRepository;

        public RentInstanceLogic(IRentInstanceRepository rentInstanceRepository)
        {
            _rentInstanceRepository = rentInstanceRepository;
        }

        public void CreateRentInstance(RentInstance rentInstance)
        {
            // Implement error handling, validation, etc.
            _rentInstanceRepository.Create(rentInstance);
        }
        public RentInstance GetRentInstance(int id)
        {
            return _rentInstanceRepository.Read(id);
        }
        public IEnumerable<RentInstance> GetAllRentInstances()
        {
            return _rentInstanceRepository.ReadAll();
        }
        public void UpdateRentInstance(RentInstance rentInstance)
        {
            // Implement error handling, validation, etc.
            _rentInstanceRepository.Update(rentInstance);
        }
        public void DeleteRentInstance(int id)
        {
            _rentInstanceRepository.Delete(id);
        }
        public IEnumerable<Brand> GetBrandsForRentInstance(int rentInstanceId)
        {
            // Implement logic to retrieve brands for a rent instance
            throw new NotImplementedException();
        }
        public IEnumerable<CarModel> GetCarModelsForRentInstance(int rentInstanceId)
        {
            // Implement logic to retrieve car models for a rent instance
            throw new NotImplementedException();
        }
    }
}