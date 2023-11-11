using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public ICollection<CarModel> CarModels { get; set; }
    }
}