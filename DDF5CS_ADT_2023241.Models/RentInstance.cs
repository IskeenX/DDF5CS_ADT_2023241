using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Models
{
    public class RentInstance
    {
        public int RentInstanceId { get; set; }
        public DateTime RentDate { get; set; }
        
        public int CarModelId { get; set; } //Foreign key
        public CarModel? CarModel { get; set; }
    }
}