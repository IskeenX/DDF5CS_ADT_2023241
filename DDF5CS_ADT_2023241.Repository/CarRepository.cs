using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Repository
{
    public class CarRepository
    {
        private readonly AppDbContext _dbContext;

        public CarRepository(AppDbContext dbContext) { _dbContext = dbContext; }
    }
}