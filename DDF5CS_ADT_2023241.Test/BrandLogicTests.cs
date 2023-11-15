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
        [Test] // Non-CRUD type
        public void GetModelsForBrand_ShouldReturnModels()
        {
            var mockBrandRepository = new Mock<IBrandRepository>();
            mockBrandRepository.Setup(repo => repo.GetModelsForBrand(It.IsAny<int>())).Returns(new List<CarModel> { new CarModel() });

            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            var result = brandLogic.GetModelsForBrand(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }
        [Test] // Non-CRUD type
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
        [Test] // Create type
        public void CreateBrand_ShouldCreateBrand()
        {
            var brand = new Brand { BrandId = 1, BrandName = "Brand1" };
            var mockBrandRepository = new Mock<IBrandRepository>();
            mockBrandRepository.Setup(repo => repo.Create(brand));

            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            brandLogic.CreateBrand(brand);

            mockBrandRepository.Verify(repo => repo.Create(brand), Times.Once);
        }
        [Test] // Create type
        public void CreateBrand_WithEmptyName_ShouldThrowException()
        {
            var mockBrandRepository = new Mock<IBrandRepository>();
            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            Brand brand = new Brand { BrandId = 1, BrandName = "" };

            // Adjusted code to expect ArgumentException with a specific message
            var exception = Assert.Throws<ArgumentException>(() => brandLogic.CreateBrand(brand));
            Assert.AreEqual("Brand name cannot be empty", exception?.Message); // Customize the message as needed
        }
        [Test] // Freely selected type
        public void UpdateBrand_WithValidBrand_ShouldUpdateSuccessfully()
        {
            var mockBrandRepository = new Mock<IBrandRepository>();
            var brandLogic = new BrandLogic(mockBrandRepository.Object);

            Brand existingBrand = new Brand { BrandId = 1, BrandName = "ExistingBrand" };
            Brand updatedBrand = new Brand { BrandId = 1, BrandName = "UpdatedBrand" };

            mockBrandRepository.Setup(repo => repo.Read(It.IsAny<int>())).Returns(existingBrand);

            brandLogic.UpdateBrand(updatedBrand);

            mockBrandRepository.Verify(repo => repo.Update(updatedBrand), Times.Once);
        }
    }
}