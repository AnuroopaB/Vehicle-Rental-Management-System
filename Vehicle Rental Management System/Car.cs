using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}\nManufacturer is {Manufacturer}\nYear is {Year}\nRentalPrice is {RentalPrice}\n");
        }
    }
}