//Truck class

namespace Vehicle_Rental_Management_System
{
    //Inheritance
    //Inheriting properties of parent class Vehicle
    class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }
 
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"{vName}\n--------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nCapacity\t:\t{Capacity}\nType of Truck\t:\t{TruckType}\nFour wheel drive:\t{(FourWheelDrive ? "Yes":"No")}\nRental status\t:\t{(rentalStatus ? "Rented" : "Available")}\n");
        }

        //Method for getting common and specific truck property details from user
        public void TruckDetails()
        {
            VehicleDetails();
            Console.Write("Enter the passenger capacity: ");
            Capacity = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of truck: ");
            TruckType = Console.ReadLine();
            Console.Write("Is it four wheel drive (Yes/No)? ");
            string check = (Console.ReadLine()).ToLower();
            FourWheelDrive = check == "yes" ? true : false;
        }
    }
}
