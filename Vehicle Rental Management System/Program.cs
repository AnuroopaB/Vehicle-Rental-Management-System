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
                RentalPrice = 120,
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
                RentalPrice = 599,
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
                RentalPrice = 60,
                EngineCapacity = 150,
                FuelType = "HGF",
                HasFairing = true,
                vName = "Motorcycle_1"
            };
            rentalAgency.Fleet[0] = car;
            rentalAgency.Fleet[1] = truck;
            rentalAgency.Fleet[2] = motorcycle;
            rentalAgency.TotalRevenue = 779.00;
            rentalAgency.count = 2;
            //need to fix
            Console.WriteLine("Welcome to Virtual Rental Management System\n*******************************************");
            while (input != -1)
            {
                Console.Write("\nEnter 1 to know about the system\nEnter 2 to select a vehicle for rent\nEnter 3 to add a vehicle to system\nEnter 4 to remove a vehicle from system\nEnter any other number to Exit\n\nEnter your selection: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"\nAbout\n-----\n->This is a vehicle management system developed in 2024.\n->The aim of this system is to provide a platform for renting and keeping track of all the rental vehicles.\n->Vehicles include multiple variants of motorcycles, cars and trucks.\n->There are a total of {rentalAgency.count+1} vehicles registered in the system.\n->The total revenue of Rental Management System is {rentalAgency.TotalRevenue} CAD.\n");
                        break;
                    case 2:
                        rentalAgency.RentVehicle();
                        break;
                    case 3:
                        rentalAgency.AddVehicle();
                        break;
                    case 4:
                        rentalAgency.RemoveVehicle();
                        break;
                    default:
                        input = -1;
                        break;
                }
                if (input == -1)
                {
                    break;
                }
                Console.Write("\nDo you want to go to the menu (Yes/No)? ");
                string userInput = Console.ReadLine().ToLower();
                input = userInput == "yes" ? input : -1;
            }
            Console.WriteLine("\nExiting...");
        }
    }
}