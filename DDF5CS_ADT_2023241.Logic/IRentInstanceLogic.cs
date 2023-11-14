using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface IRentInstanceLogic
    {
        void CreateRentInstance(RentInstance rentInstance);
        RentInstance? GetRentInstance(int id);
        IEnumerable<RentInstance> GetAllRentInstances();
        void UpdateRentInstance(RentInstance rentInstance);
        void DeleteRentInstance(int id);
    }
}