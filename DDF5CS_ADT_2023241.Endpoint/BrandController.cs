using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDF5CS_ADT_2023241.Endpoint
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandLogic _brandLogic;

        public BrandController(IBrandLogic brandLogic)
        {
            _brandLogic = brandLogic;
        }

        [HttpGet("{id}")]
        public IActionResult GetBrand(int id)
        {
            var brand = _brandLogic.GetBrand(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var brands = _brandLogic.GetAllBrands();
            return Ok(brands);
        }

        [HttpPost]
        public IActionResult CreateBrand([FromBody] Brand brand)
        {
            if (brand == null)
            {
                return BadRequest();
            }

            try
            {
                _brandLogic.CreateBrand(brand);
                return CreatedAtAction(nameof(GetBrand), new { id = brand.BrandId }, brand);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBrand(int id, [FromBody] Brand brand)
        {
            if (brand == null || id != brand.BrandId)
            {
                return BadRequest();
            }

            try
            {
                _brandLogic.UpdateBrand(brand);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            try
            {
                _brandLogic.DeleteBrand(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}