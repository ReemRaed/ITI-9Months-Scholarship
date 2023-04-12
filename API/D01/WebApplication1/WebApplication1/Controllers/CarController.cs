using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection;
using WebApplication1.Filters;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly IConfiguration _configuration;

        public CarController(ILogger<CarController> logger
            , IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet]
        public ActionResult<List<Car>> GetAll() {
            _logger.LogCritical("GetALL");

            return Car.cars; }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Car> Get(int id) 
        {
        
            Car? car = Car.cars.FirstOrDefault(m => m.ID == id);
            if (car is null)
            {
                return NotFound();
            }

            return car;
        }

        [HttpPost]
        [Route("v1")]
        public IActionResult Add(Car car)
        {
            car.ID=new Random().Next(10,1000);
            car.Type = "Gas";
            Car.cars.Add(car);
            return CreatedAtAction( actionName:nameof(Get), 
                routeValues:new {id=car.ID},
                value: new { Message= "Created sucessfully"});

        }

        [HttpPost]
        [Route("v2")]
        [validateType]
        public IActionResult Addv2(Car car)
        {
            car.ID = new Random().Next(10, 1000);
            Car.cars.Add(car);
            return CreatedAtAction(actionName: nameof(Get),
                routeValues: new { id = car.ID },
                value: new { Message = "Created sucessfully" });

        }

        [HttpPut]
        [Route("id")]

        public IActionResult Upadte(Car car , int id)
        {
            if (id != car.ID) { return BadRequest(); }

            var UpdatedCar=Car.cars.Find(e=>e.ID==id) as Car;
            if(UpdatedCar is null) { return NotFound(); }

            UpdatedCar.name = car.name;
            UpdatedCar.color = car.color;
            UpdatedCar.Model = car.Model;
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var UpdatedCar = Car.cars.Find(e => e.ID == id) as Car;
            if (UpdatedCar is null) { return NotFound(); }
            Car.cars.Remove(UpdatedCar);
            return NoContent();

        }
        [HttpGet]
        [Route("c")]
        public ActionResult GetCounterRequests()
        {
            return Ok(Program.counter);
        }
    }
}
