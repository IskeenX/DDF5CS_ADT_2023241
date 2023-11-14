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
    public class BrandLogicTests
    {
        [Test]
        public void GetModelsForBrand_ShouldReturnModels()
        {
            var mockBrandRepository = new Mock<IBrandRepository>();
            mockBrandRepository.Setup(repo => repo.GetModelsForBrand(It.IsAny<int>())).Returns(new List<CarModel> { new CarModel() });

            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            var result = brandLogic.GetModelsForBrand(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public void GetAllBrands_ShouldReturnAllBrands()
        {
            var mockBrandRepository = new Mock<IBrandRepository>();
            mockBrandRepository.Setup(repo => repo.GetAllBrands()).Returns(new List<Brand>
                {
                new Brand { BrandId = 1, BrandName = "Brand1" },
                new Brand { BrandId = 2, BrandName = "Brand2" }
                });

            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            var result = brandLogic.GetAllBrands();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public void CreateBrand_ShouldCreateBrand()
        {
            var brand = new Brand { BrandId = 1, BrandName = "Brand1" };
            var mockBrandRepository = new Mock<IBrandRepository>();
            mockBrandRepository.Setup(repo => repo.Create(brand));

            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            brandLogic.CreateBrand(brand);

            mockBrandRepository.Verify(repo => repo.Create(brand), Times.Once);
        }
    }
}