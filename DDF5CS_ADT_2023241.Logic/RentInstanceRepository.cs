using DDF5CS_ADT_2023241.Models;
using DDF5CS_ADT_2023241.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class RentInstanceRepository : IRentInstanceRepository
    {
        private readonly AppDbContext _dbContext;

        public RentInstanceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<RentInstance> GetAllRentInstances()
        {
            return _dbContext.RentInstances.ToList();
        }

        public void Create(RentInstance rentInstance)
        {
            _dbContext.RentInstances.Add(rentInstance);
            _dbContext.SaveChanges();
        }
        public RentInstance? Read(int id)
        {
            return _dbContext.RentInstances.Find(id);
        }
        public IQueryable<RentInstance> ReadAll()
        {
            return _dbContext.RentInstances.AsQueryable();
        }
        public void Update(RentInstance rentInstance)
        {
            _dbContext.RentInstances.Update(rentInstance);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var rentInstance = _dbContext.RentInstances.Find(id);
            if (rentInstance != null)
            {
                _dbContext.RentInstances.Remove(rentInstance);
                _dbContext.SaveChanges();
            }
        }
    }
}