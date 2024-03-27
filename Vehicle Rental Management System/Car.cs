//Car class

using System;

namespace Vehicle_Rental_Management_System
{
    //Inheritance
    //Inheriting properties of parent class Vehicle
    class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }
        
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"{vName}\n------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nSeats\t\t:\t{Seats}\nEngine type\t:\t{EngineType}\nTransmisson\t:\t{Transmission}\nConvertible\t:\t{(Convertible ? "Yes":"No")}\nRental status\t:\t{(rentalStatus ? "Rented" : "Available")}\n");
        }

        //Method for getting common and specific car property details from user
        public void CarDetails()
        {
            VehicleDetails();
            Console.Write("Enter the number of seats: ");
            Seats = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of engine: ");
            EngineType = Console.ReadLine();
            Console.Write("Enter the Transmission: ");
            Transmission = Console.ReadLine();
            Console.Write("Is it covertible (Yes/No)? ");
            string check = (Console.ReadLine()).ToLower();
            Convertible = check == "yes" ? true : false;
        }
    }
}