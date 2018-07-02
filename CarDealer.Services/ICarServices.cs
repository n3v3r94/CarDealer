using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Services
{
    using Models;
    using System.Collections.Generic;
  public  interface ICarServices
    {
        IEnumerable<CarModel> ByMake(string make);

    }
}
