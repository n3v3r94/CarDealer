using System;


namespace CarDealer.Services.Implementation
{
    using Data;
    using System.Collections.Generic;
    using CarDealer.Services.Models;
    using System.Linq;
    public class CarService : ICarServices
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<CarModel> ByMake(string make)


                 => this.db.Cars.Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model).ThenBy(t => t.TravelledDistance)
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance

                }).ToList();
    }
}

