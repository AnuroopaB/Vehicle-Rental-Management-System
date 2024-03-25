using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Vehicle_Rental_Management_System
{
    class RentalAgency
    {
        public Vehicle[] Fleet = new Vehicle[10];
        public int TotalRevenue {  get; set; }
        public string vehicleType, model, manufacturer, owner, engineType, transmission, vName, truckType, fuelType;
        int year, seats, engineCapacity, carIncrement = 2, truckIncrement = 2, motorCycleIncrement = 2, count = 2;
        double rentalPrice;
        float capacity;
        bool convertible, fourWheelDrive, hasFairing;
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
                Console.WriteLine($"\nNew car added successfully!");
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
                Console.WriteLine($"\nNew truck added successfully!");
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
                Console.WriteLine($"\nNew motorcycle added successfully!");
            }
            else
            {
                Console.WriteLine("\nWrong vehicle type, enter a valid type.");
                AddVehicle();
            }
        }
        public void RemoveVehicle()
        {
        }
        public void RentVehicle()
        {
            string vehicleName;
            int i, j = -1;
            Console.WriteLine("\nPlease find the list of available vehicles:\n");
            for (i = 0; i <= count; i++)
            {
                Fleet[i].DisplayDetails();
            }
            Console.Write("\nEnter the vehicle name for rental: ");
            vehicleName = Console.ReadLine().ToLower();
            for (i = 0; i <= count; i++)
            {
                if(Fleet[i].vName.ToLower() == vehicleName)
                {
                    j=i; break;
                }
            }
            if(j != -1)
            {
                if (Fleet[j].rentalStatus == true)
                {
                    Console.WriteLine("Sorry, the vehicle is already rented.");
                }
                else
                {
                    Fleet[j].rentalStatus = true;
                    Console.WriteLine($"\nSuccesfully rented {Fleet[j].vName}!");
                }
            }
            else { Console.WriteLine("\nEntered vehicle name is not found, please try again!"); }
            Console.WriteLine("Do you want to rent another vehicle? (Yes/No) ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                RentVehicle();
            }
        }
        void VehicleProperties(string vehicleType)
        {
            string check;
            Console.Write("\nEnter the model of vehicle: ");
            model = Console.ReadLine();
            Console.Write("\nEnter the manufacturer of vehicle: ");
            manufacturer = Console.ReadLine();
            Console.Write("\nEnter the year of manufacture: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the rental price: ");
            rentalPrice = double.Parse(Console.ReadLine());
            if (vehicleType == "car")
            {
                Console.Write("\nEnter the number of seats: ");
                seats = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the type of engine: ");
                engineType = Console.ReadLine();
                Console.Write("\nEnter the Transmission: ");
                transmission = Console.ReadLine();
                Console.Write("\nIs it covertible? (Yes/No) ");
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
                Console.Write("\nIs it four wheel drive? (Yes/No) ");
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
                Console.Write("\nHas fairing? (Yes/No) ");
                check = (Console.ReadLine()).ToLower();
                hasFairing = check == "yes" ? true : false;
                this.vName = "Motorcycle_" + motorCycleIncrement.ToString();
                motorCycleIncrement++;
            }
        }
    }
}