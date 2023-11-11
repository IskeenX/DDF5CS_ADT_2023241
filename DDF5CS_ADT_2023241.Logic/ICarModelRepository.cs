using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface ICarModelRepository
    {
        void Create(CarModel carModel);
        CarModel Read(int id);
        IQueryable<CarModel> ReadAll();
        void Update(CarModel carModel);
        void Delete(int id);
    }
}