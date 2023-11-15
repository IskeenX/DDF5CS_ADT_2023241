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

        public CarModelLogic(ICarModelRepository carModelRepository) { _carModelRepository = carModelRepository; }
        public IEnumerable<CarModel> GetAllCarModels() { return _carModelRepository.GetAllCarModels(); }
        public void CreateCarModel(CarModel carModel) { _carModelRepository.Create(carModel); }
        public CarModel? GetCarModel(int id) { return _carModelRepository.Read(id); }
        public void UpdateCarModel(CarModel carModel) { _carModelRepository.Update(carModel); }
        public void DeleteCarModel(int id) { _carModelRepository.Delete(id); }
    }
}