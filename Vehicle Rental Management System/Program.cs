using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Xml.Linq;

namespace Vehicle_Rental_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            RentalAgency rentalAgency = new RentalAgency();
            Car car = new Car
            {
                Model = "HGHGH",
                Manufacturer = "HGHGJ",
                Year = 2016,
                RentalPrice = 250,
                Seats = 5,
                EngineType = "HFDF",
                Transmission = "FSFD",
                Convertible = true,
                vName = "Car_1",
            };
            Truck truck = new Truck
            {
                Model = "FGDFD",
                Manufacturer = "GFGXV",
                Year = 2013,
                RentalPrice = 500,
                Capacity = 19.4F,
                TruckType = "FDGF",
                FourWheelDrive = true,
                vName = "Truck_1"
            };
            Motorcycle motorcycle = new Motorcycle
            {
                Model = "EWEW",
                Manufacturer = "TYTY",
                Year = 2020,
                RentalPrice = 120,
                EngineCapacity = 150,
                FuelType = "HGF",
                HasFairing = true,
                vName = "Motorcycle_1"
            };
            rentalAgency.Fleet[0] = car;
            rentalAgency.Fleet[1] = truck;
            rentalAgency.Fleet[2] = motorcycle;
            //need to fix
            Console.WriteLine("Welcome to Virtual Rental Management System\n*******************************************");
            while (input != -1)
            {
                Console.Write("\nEnter 1 to select a vehicle for rent\nEnter 2 to add a vehicle to system\nEnter 3 to remove a vehicle from system\nEnter any other number to Exit\n\nEnter your selection: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        rentalAgency.RentVehicle();
                        break;
                    case 2:
                        rentalAgency.AddVehicle();
                        break;
                    case 3:
                        rentalAgency.RemoveVehicle();
                        break;
                    default:
                        Console.WriteLine("\nExiting...");
                        input = -1;
                        break;
                }
                Console.WriteLine("\nDo you want to go to the menu?(Yes/No)");
                string userInput = Console.ReadLine().ToLower();
                input = userInput == "yes" ? input : -1;
            }
        }
    }
}