


namespace CarDealer.Wep.Controllers
{
    using System.Diagnostics;
  
    using Microsoft.AspNetCore.Mvc;
    using CarDealer.Wep.Models;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

     
       // public IActionResult Error()
       // {
       //  //   return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       // }
    }
}
