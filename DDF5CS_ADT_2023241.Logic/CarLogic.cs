﻿using DDF5CS_ADT_2023241.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Logic
{
    public class CarLogic
    {
        private readonly AppDbContext _dbContext;

        public CarLogic(AppDbContext dbContext) { _dbContext = dbContext; }
    }
}