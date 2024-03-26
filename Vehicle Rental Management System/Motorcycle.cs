//Motorcycle class

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
            Console.WriteLine($"{vName}\n-------------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nEngine capacity\t:\t{EngineCapacity}\nFuel type\t:\t{FuelType}\nHas Fairing\t:\t{HasFairing}\nRental status\t:\t{rentalStatus}\n");
        }
    }
}
