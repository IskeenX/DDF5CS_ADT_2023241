using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF5CS_ADT_2023241.Test
{
    [TestFixture]
    public class CarModelLogicTests
    {
        [Test]
        public void GetAllCarModels_ShouldReturnAllCarModels()
        {
            var mockCarModelRepository = new Mock<ICarModelRepository>();
            mockCarModelRepository.Setup(repo => repo.GetAllCarModels()).Returns(new List<CarModel>
                {
                new CarModel { CarModelId = 1, ModelName = "Model1" },
                new CarModel { CarModelId = 2, ModelName = "Model2" }
                });

            var carModelLogic = new CarModelLogic(mockCarModelRepository.Object);

            var result = carModelLogic.GetAllCarModels();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }
}