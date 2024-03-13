using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }
        /*Vehicle(string Model, string Manufacturer, int Year, double RentalPrice)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;  
            this.Year = Year;
            this.RentalPrice = RentalPrice;
        }*/
        void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}\nManufacturer is {Manufacturer}\nYear is {Year}\nRentalPrice is {RentalPrice}\n");
        }
    }
}
