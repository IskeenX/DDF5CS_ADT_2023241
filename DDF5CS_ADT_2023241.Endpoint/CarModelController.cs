using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDF5CS_ADT_2023241.Endpoint
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelLogic _carModelLogic;

        public CarModelController(ICarModelLogic carModelLogic)
        {
            _carModelLogic = carModelLogic;
        }

        [HttpGet("{id}")]
        public IActionResult GetCarModel(int id)
        {
            var carModel = _carModelLogic.GetCarModel(id);
            if (carModel == null)
            {
                return NotFound();
            }
            return Ok(carModel);
        }

        [HttpGet]
        public IActionResult GetAllCarModels()
        {
            var carModels = _carModelLogic.GetAllCarModels();
            return Ok(carModels);
        }

        [HttpPost]
        public IActionResult CreateCarModel([FromBody] CarModel carModel)
        {
            if (carModel == null)
            {
                return BadRequest();
            }

            try
            {
                _carModelLogic.CreateCarModel(carModel);
                return CreatedAtAction(nameof(GetCarModel), new { id = carModel.CarModelId }, carModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCarModel(int id, [FromBody] CarModel carModel)
        {
            if (carModel == null || id != carModel.CarModelId)
            {
                return BadRequest();
            }

            try
            {
                _carModelLogic.UpdateCarModel(carModel);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarModel(int id)
        {
            try
            {
                _carModelLogic.DeleteCarModel(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}