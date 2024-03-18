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
            Console.Write("\nEnter the engine capacity: ");
            this.EngineCapacity = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the type of fuel: ");
            this.FuelType = Console.ReadLine();
            Console.Write("\nHas fairing? (Yes/No) ");
            string check = (Console.ReadLine()).ToLower();
            if (check == "yes")
            {
                this.HasFairing = true;
            }
            else
            {
                this.HasFairing = false;
            }
        }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}.\nManufacturer is {Manufacturer}.\nYear is {Year}\nRentalPrice is {RentalPrice}.\nEngine capacity is {EngineCapacity}.\nFuel type is {FuelType}.\nHas Fairing: {HasFairing}.\n");
        }
    }
}
