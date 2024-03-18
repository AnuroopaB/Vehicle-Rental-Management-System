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
        public Car(string model, string manufacturer, int year, double rentalPrice)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
            this.RentalPrice = rentalPrice;
            Console.Write("\nEnter the number of seats: ");
            this.Seats = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the type of engine: ");
            this.EngineType = Console.ReadLine();
            Console.Write("\nEnter the Transmission: ");
            this.Transmission = Console.ReadLine();
            Console.Write("\nIs it covertible? (Yes/No) ");
            string check = (Console.ReadLine()).ToLower();
            if (check == "yes")
            {
                this.Convertible = true;
            }
            else
            {
                this.Convertible = false;
            }

        }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}\nManufacturer is {Manufacturer}.\nYear is {Year}.\nRental price is {RentalPrice}.\nThere are {Seats} seats.\nEngine type is {EngineType}.\nTransmisson is {Transmission}.\nConvertible: {Convertible}.\n");
        }
        
    }
}