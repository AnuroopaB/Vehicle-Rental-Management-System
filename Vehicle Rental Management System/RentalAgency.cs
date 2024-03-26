//Rental Agency class

using System;

namespace Vehicle_Rental_Management_System
{
    class RentalAgency
    {
        public Vehicle[] Fleet = new Vehicle[50];
        public double TotalRevenue { get; set; }
        public int count { get; set; }
        string vehicleType, model, manufacturer, owner, engineType, transmission, vName, truckType, fuelType;
        int year, seats, engineCapacity, carIncrement = 2, truckIncrement = 2, motorCycleIncrement = 2;
        double rentalPrice;
        float capacity;
        bool convertible, fourWheelDrive, hasFairing;

        //Method for adding vehicles
        public void AddVehicle()
        {
            Console.Write("\nEnter the type of vehicle (Car/Truck/Motorcycle): ");
            string vehicleType = (Console.ReadLine()).ToLower();
            if (vehicleType == "car")
            {
                VehicleProperties(vehicleType);
                Car car = new Car
                {
                    Model = model,
                    Manufacturer = manufacturer,
                    Year = year,
                    RentalPrice = rentalPrice,
                    Seats = seats,
                    EngineType = engineType,
                    Transmission = transmission,
                    Convertible = convertible,
                    vName = vName
                };
                Fleet[count++] = car;
                CheckAdd("car",vName);
            }
            if (vehicleType == "truck")
            {
                VehicleProperties(vehicleType);
                Truck truck = new Truck
                {
                    Model = model,
                    Manufacturer = manufacturer,
                    Year = year,
                    RentalPrice = rentalPrice,
                    Capacity = capacity,
                    TruckType = truckType,
                    FourWheelDrive = fourWheelDrive,
                    vName = vName
                };
                Fleet[count++] = truck;
                CheckAdd("truck", vName);
            }
            else if (vehicleType == "motorcycle")
            {
                VehicleProperties(vehicleType);
                Motorcycle motorcycle = new Motorcycle
                {
                    Model = model,
                    Manufacturer = manufacturer,
                    Year = year,
                    RentalPrice = rentalPrice,
                    EngineCapacity = engineCapacity,
                    FuelType = fuelType,
                    HasFairing = hasFairing,
                    vName = vName
                };
                Fleet[count++] = motorcycle;
                CheckAdd("motorcycle", vName);
            }
            else
            {
                Console.WriteLine("\nWrong vehicle type, enter a valid type.");
                AddVehicle();
            }
        }

        //Method for removing vehicles
        public void RemoveVehicle()
        {
            string vehicleName;
            int index;
            DisplayFleet();
            Console.Write("\nEnter the vehicle name for removing from System: ");
            vehicleName = Console.ReadLine().ToLower();
            index = FindIndex(vehicleName);
            if (index != -1)
            {
                if (Fleet[index].rentalStatus == true)
                {
                    Console.WriteLine("Sorry, the vehicle is already in rental status, cannot be removed now.");
                }
                else
                {
                    Fleet[index] = null;
                    for (int i = index; i <= count; i++)
                    {
                        Fleet[i] = Fleet[i + 1];
                    }
                    count--;
                    Console.WriteLine($"\nSuccesfully removed {Fleet[index].vName}!");
                    DisplayFleet();
                }
            }
            else { Console.WriteLine("\nEntered vehicle name is not found, please try again!"); }
            Console.Write("Do you want to remove another vehicle? (Yes/No) ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                RemoveVehicle();
            }
        }

        //Method for renting vehicles
        public void RentVehicle()
        {
            string vehicleName;
            int index, days;
            Console.WriteLine("\nPlease find the list of available vehicles:\n");
            DisplayFleet();
            Console.Write("\nEnter the vehicle name for rental: ");
            vehicleName = Console.ReadLine().ToLower();
            index = FindIndex(vehicleName);
            if(index != -1)
            {
                if (Fleet[index].rentalStatus == true)
                {
                    Console.WriteLine("Sorry, the vehicle is already rented.");
                }
                else
                {
                    Fleet[index].rentalStatus = true;
                    Console.Write("\nTotal days of rent: ");
                    days = int.Parse(Console.ReadLine());
                    TotalRevenue += Fleet[index].RentalPrice*days;
                    Console.WriteLine($"\nSuccesfully rented {Fleet[index].vName}!");
                }
            }
            else { Console.WriteLine("\nEntered vehicle name is not found, please try again!"); }
            Console.Write("Do you want to rent another vehicle? (Yes/No) ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                RentVehicle();
            }
        }

        //Method for getting common and specific vehicle property details from user
        void VehicleProperties(string vehicleType)
        {
            string check;
            Console.Write("\nEnter the model of vehicle: ");
            model = Console.ReadLine();
            Console.Write("\nEnter the manufacturer of vehicle: ");
            manufacturer = Console.ReadLine();
            Console.Write("\nEnter the year of manufacture: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the rental price per day: ");
            rentalPrice = double.Parse(Console.ReadLine());
            if (vehicleType == "car")
            {
                Console.Write("\nEnter the number of seats: ");
                seats = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the type of engine: ");
                engineType = Console.ReadLine();
                Console.Write("\nEnter the Transmission: ");
                transmission = Console.ReadLine();
                Console.Write("\nIs it covertible (Yes/No)? ");
                check = (Console.ReadLine()).ToLower();
                convertible = check == "yes" ? true : false;
                vName = "Car_" + carIncrement.ToString();
                carIncrement++;
            }
            else if (vehicleType == "truck")
            {
                Console.Write("\nEnter the capacity in litres: ");
                capacity = float.Parse(Console.ReadLine());
                Console.Write("\nEnter the type of truck: ");
                truckType = Console.ReadLine();
                Console.Write("\nIs it four wheel drive (Yes/No)? ");
                check = (Console.ReadLine()).ToLower();
                fourWheelDrive = check == "yes" ? true : false;
                vName = "Truck_" + truckIncrement.ToString();
                truckIncrement++;
            }
            else
            {
                Console.Write("\nEnter the engine capacity: ");
                engineCapacity = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the type of fuel: ");
                fuelType = Console.ReadLine();
                Console.Write("\nHas fairing (Yes/No)? ");
                check = (Console.ReadLine()).ToLower();
                hasFairing = check == "yes" ? true : false;
                this.vName = "Motorcycle_" + motorCycleIncrement.ToString();
                motorCycleIncrement++;
            }
        }

        //Method for displaying all the vehicle details added in fleet
        void DisplayFleet()
        {
            for (int i = 0; i <= count; i++)
            {
                Fleet[i].DisplayDetails();
            }
        }

        //Method for checking with user on consecutive addition of vehicles
        void CheckAdd(string vehicle, string vehicleName)
        {
            Console.WriteLine($"\nNew {vehicle} {vehicleName} added successfully!");
            Console.Write("Do you want to add another {vehicle} (Yes/No)? ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                AddVehicle();
            }
        }

        //Method for finding the index of vehicle object in fleet
        int FindIndex(string vehicleName)
        {
            int index = -1;
            for (int i = 0; i <= count; i++)
            {
                if (Fleet[i].vName.ToLower() == vehicleName)
                {
                    index = i; break;
                }
            }
            return index;
        }
    }
}