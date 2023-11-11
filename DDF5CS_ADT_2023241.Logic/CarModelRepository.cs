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
    public class CarModelRepository
    {
        private readonly AppDbContext _dbContext;

        public CarModelRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(CarModel carModel)
        {
            _dbContext.CarModels.Add(carModel);
            _dbContext.SaveChanges();
        }
        public CarModel Read(int id)
        {
            return _dbContext.CarModels.Find(id);
        }
        public IQueryable<CarModel> ReadAll()
        {
            return _dbContext.CarModels.AsQueryable();
        }
        public void Update(CarModel carModel)
        {
            _dbContext.CarModels.Update(carModel);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var carModel = _dbContext.CarModels.Find(id);
            if (carModel != null)
            {
                _dbContext.CarModels.Remove(carModel);
                _dbContext.SaveChanges();
            }
        }
    }
}