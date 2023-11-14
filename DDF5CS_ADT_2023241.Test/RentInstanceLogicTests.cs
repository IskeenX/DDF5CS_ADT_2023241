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
    public class RentInstanceLogicTests
    {
        [Test]
        public void GetAllRentInstances_ShouldReturnAllRentInstances()
        {
            var mockRentInstanceRepository = new Mock<IRentInstanceRepository>();
            mockRentInstanceRepository.Setup(repo => repo.GetAllRentInstances()).Returns(new List<RentInstance>
                {
                new RentInstance { RentInstanceId = 1, RentDate = DateTime.Now },
                new RentInstance { RentInstanceId = 2, RentDate = DateTime.Now }
                });

            var rentInstanceLogic = new RentInstanceLogic(mockRentInstanceRepository.Object);

            var result = rentInstanceLogic.GetAllRentInstances();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }
}