using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface IBrandLogic
    {
        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(int id);
        Brand? GetBrand(int id);
        IEnumerable<Brand> GetAllBrands();
        IEnumerable<CarModel> GetModelsForBrand(int brandId);
    }
}