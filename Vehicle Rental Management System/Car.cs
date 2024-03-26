//Car class

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
            Console.WriteLine($"{vName}\n------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nSeats\t\t:\t{Seats}\nEngine type\t:\t{EngineType}\nTransmisson\t:\t{Transmission}\nConvertible\t:\t{Convertible}\nRental status\t:\t{rentalStatus}\n");
        }   
    }
}