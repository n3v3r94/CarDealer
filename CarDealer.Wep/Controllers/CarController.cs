

namespace CarDealer.Wep.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.Cars;
    using CarDealer.Services;
    public class CarController : Controller
    {
        private readonly ICarServices cars;

        public CarController(ICarServices cars)
        {
            this.cars = cars;
        }
        [Route("cars/{make}")]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return View(new CarsByMakeModel
            {
                Make = make,
                Cars = cars
            });
          
        }
    } 
}
