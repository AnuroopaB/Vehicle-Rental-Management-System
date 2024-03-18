using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }
        public Motorcycle(string model, string manufacturer, int year, double rentalPrice)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
            this.RentalPrice = rentalPrice;

        }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}\nManufacturer is {Manufacturer}\nYear is {Year}\nRentalPrice is {RentalPrice}\n");
        }
    }
}
