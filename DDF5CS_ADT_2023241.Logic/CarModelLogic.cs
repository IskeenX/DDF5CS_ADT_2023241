using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class CarModelLogic : ICarModelLogic
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelLogic(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }

        public void CreateCarModel(CarModel carModel)
        {
            // Implement error handling, validation, etc.
            _carModelRepository.Create(carModel);
        }
        public CarModel GetCarModel(int id)
        {
            return _carModelRepository.Read(id);
        }
        public IEnumerable<CarModel> GetAllCarModels()
        {
            return _carModelRepository.ReadAll();
        }
        public void UpdateCarModel(CarModel carModel)
        {
            // Implement error handling, validation, etc.
            _carModelRepository.Update(carModel);
        }
        public void DeleteCarModel(int id)
        {
            _carModelRepository.Delete(id);
        }
        public IEnumerable<Brand> GetBrandsForCarModel(int carModelId)
        {
            // Implement logic to retrieve brands for a car model
            throw new NotImplementedException();
        }
        public IEnumerable<RentInstance> GetRentInstancesForCarModel(int carModelId)
        {
            // Implement logic to retrieve rent instances for a car model
            throw new NotImplementedException();
        }
    }
}