
namespace CarDealer.Data.Models
{
   public class PartCar
    {
        //Many To Many
        public int PartId { get; set; }

        public Part Part { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

    }
}
