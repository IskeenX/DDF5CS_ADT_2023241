using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public interface IRentInstanceRepository
    {
        void Create(RentInstance rentInstance);
        void Update(RentInstance rentInstance);
        void Delete(int id);
        RentInstance? Read(int id);
        IQueryable<RentInstance> ReadAll();
        IEnumerable<RentInstance> GetAllRentInstances();
    }
}