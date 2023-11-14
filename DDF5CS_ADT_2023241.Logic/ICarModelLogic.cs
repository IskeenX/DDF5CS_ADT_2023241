using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface ICarModelLogic
    {
        void CreateCarModel(CarModel carModel);
        CarModel? GetCarModel(int id);
        IEnumerable<CarModel> GetAllCarModels();
        void UpdateCarModel(CarModel carModel);
        void DeleteCarModel(int id);
    }
}