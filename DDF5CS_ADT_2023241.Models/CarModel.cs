using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        public string ModelName { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<RentInstance> RentInstances { get; set; }
    }
}