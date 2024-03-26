namespace Vehicle_Rental_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            //Sample vehicle data
            Car car = new Car
            {
                Model = "Ford Mustang",
                Manufacturer = "Ford",
                Year = 2022,
                RentalPrice = 150,
                Seats = 4,
                EngineType = "5.0L V8",
                Transmission = "10-speed automatic",
                Convertible = true,
                vName = "Car_1",
            };
            Truck truck = new Truck
            {
                Model = "Chevrolet Colorado",
                Manufacturer = "Chevrolet",
                Year = 2021,
                RentalPrice = 75,
                Capacity = 5,
                TruckType = "Mid-size pickup truck",
                FourWheelDrive = true,
                vName = "Truck_1"
            };
            Motorcycle motorcycle = new Motorcycle
            {
                Model = "Kawasaki Ninja 650",
                Manufacturer = "Kawasaki",
                Year = 2023,
                RentalPrice = 100,
                EngineCapacity = 649,
                FuelType = "Gasoline",
                HasFairing = true,
                vName = "Motorcycle_1"
            };
            RentalAgency rentalAgency = new RentalAgency(325, 2);
            rentalAgency.Fleet[0] = car;
            rentalAgency.Fleet[1] = truck;
            rentalAgency.Fleet[2] = motorcycle;
            Console.WriteLine("Welcome to Virtual Rental Management System\n*******************************************");
            while (input != -1)
            {
                Console.Write("\nEnter 1 to know about the system\nEnter 2 to display all the registered vehicles\nEnter 3 to select a vehicle for rent\nEnter 4 to add a vehicle to system\nEnter 5 to remove a vehicle from system\nEnter any other number to Exit\n\nEnter your selection: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"\nAbout\n-----\n->This is a vehicle management system developed in 2024.\n->The aim of this system is to provide a platform for renting and keeping track of all the rental vehicles.\n->Vehicles include multiple variants of motorcycles, cars and trucks.\n->There are a total of {rentalAgency.count+1} vehicles registered in the system.\n->The total revenue of Rental Management System is {rentalAgency.TotalRevenue} CAD.\n");
                        break;
                    case 2:
                        rentalAgency.DisplayFleet();
                        break;
                    case 3:
                        rentalAgency.RentVehicle();
                        break;
                    case 4:
                        rentalAgency.AddVehicle();
                        break;
                    case 5:
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