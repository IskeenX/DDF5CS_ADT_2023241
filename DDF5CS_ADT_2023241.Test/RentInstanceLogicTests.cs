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
        [Test] // Non-CRUD type
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
        [Test] // Non-CRUD type
        public void GetRentInstance_WithNonExistentId_ShouldReturnNull()
        {
            var mockRentInstanceRepository = new Mock<IRentInstanceRepository>();
            mockRentInstanceRepository.Setup(repo => repo.Read(It.IsAny<int>())).Returns((RentInstance?)null);

            var rentInstanceLogic = new RentInstanceLogic(mockRentInstanceRepository.Object);

            var result = rentInstanceLogic.GetRentInstance(999); // Pass any non-existent ID here

            Assert.IsNull(result);
        }
        [Test]// Freely selected type
        public void DeleteRentInstance_WithValidId_ShouldDeleteSuccessfully()
        {
            var mockRentInstanceRepository = new Mock<IRentInstanceRepository>();
            var rentInstanceLogic = new RentInstanceLogic(mockRentInstanceRepository.Object);

            int rentInstanceIdToDelete = 1;

            rentInstanceLogic.DeleteRentInstance(rentInstanceIdToDelete);

            mockRentInstanceRepository.Verify(repo => repo.Delete(rentInstanceIdToDelete), Times.Once);
        }
    }
}