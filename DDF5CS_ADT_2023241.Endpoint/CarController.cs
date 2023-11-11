using Microsoft.AspNetCore.Mvc;

namespace DDF5CS_ADT_2023241.Endpoint
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarLogic _carLogic;

        public CarController(ICarLogic carLogic)
        {
            _carLogic = carLogic;
        }


    }
}