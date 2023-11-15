using DDF5CS_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class RentInstanceLogic : IRentInstanceLogic
    {
        private readonly IRentInstanceRepository _rentInstanceRepository;

        public RentInstanceLogic(IRentInstanceRepository rentInstanceRepository) { _rentInstanceRepository = rentInstanceRepository; }
        public IEnumerable<RentInstance> GetAllRentInstances() { return _rentInstanceRepository.GetAllRentInstances(); }
        public void CreateRentInstance(RentInstance rentInstance) { _rentInstanceRepository.Create(rentInstance); }
        public RentInstance? GetRentInstance(int id) { return _rentInstanceRepository.Read(id); }
        public void UpdateRentInstance(RentInstance rentInstance) { _rentInstanceRepository.Update(rentInstance); }
        public void DeleteRentInstance(int id) { _rentInstanceRepository.Delete(id); }
    }
}