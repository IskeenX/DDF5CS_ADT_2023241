using DDF5CS_ADT_2023241.Logic;
using DDF5CS_ADT_2023241.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDF5CS_ADT_2023241.Endpoint
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentInstanceController : ControllerBase
    {
        private readonly IRentInstanceLogic _rentInstanceLogic;

        public RentInstanceController(IRentInstanceLogic rentInstanceLogic)
        {
            _rentInstanceLogic = rentInstanceLogic;
        }

        [HttpGet("{id}")]
        public IActionResult GetRentInstance(int id)
        {
            var rentInstance = _rentInstanceLogic.GetRentInstance(id);
            if (rentInstance == null)
            {
                return NotFound();
            }
            return Ok(rentInstance);
        }

        [HttpGet]
        public IActionResult GetAllRentInstances()
        {
            var rentInstances = _rentInstanceLogic.GetAllRentInstances();
            return Ok(rentInstances);
        }

        [HttpPost]
        public IActionResult CreateRentInstance([FromBody] RentInstance rentInstance)
        {
            if (rentInstance == null)
            {
                return BadRequest();
            }

            try
            {
                _rentInstanceLogic.CreateRentInstance(rentInstance);
                return CreatedAtAction(nameof(GetRentInstance), new { id = rentInstance.RentInstanceId }, rentInstance);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRentInstance(int id, [FromBody] RentInstance rentInstance)
        {
            if (rentInstance == null || id != rentInstance.RentInstanceId)
            {
                return BadRequest();
            }

            try
            {
                _rentInstanceLogic.UpdateRentInstance(rentInstance);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRentInstance(int id)
        {
            try
            {
                _rentInstanceLogic.DeleteRentInstance(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}