using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface IBrandRepository
    {
        void Create(Brand brand);
        Brand? Read(int id);
        IQueryable<Brand> ReadAll();
        void Update(Brand brand);
        void Delete(int id);

        IEnumerable<CarModel> GetModelsForBrand(int brandId);
        IEnumerable<Brand> GetAllBrands();
    }
}