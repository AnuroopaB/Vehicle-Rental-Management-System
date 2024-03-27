//Motorcycle class

using Microsoft.VisualBasic.FileIO;
using System;

namespace Vehicle_Rental_Management_System
{
    //Inheritance
    //Inheriting properties of parent class Vehicle
    class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }
 
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"{vName}\n-------------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nEngine capacity\t:\t{EngineCapacity} cc\nFuel type\t:\t{FuelType}\nHas Fairing\t:\t{(HasFairing?"Yes":"No")}\nRental status\t:\t{(rentalStatus?"Rented":"Available")}\n");
        }

        //Method for getting common and specific motorcycle property details from user
        public void MotorcycleDetails()
        {
            VehicleDetails();
            Console.Write("Enter the engine capacity: ");
            EngineCapacity = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of fuel: ");
            FuelType = Console.ReadLine();
            Console.Write("Has fairing (Yes/No)? ");
            string check = (Console.ReadLine()).ToLower();
            HasFairing = check == "yes" ? true : false;
        }
    }
}
