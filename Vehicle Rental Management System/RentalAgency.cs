//Rental Agency class

using System;

namespace Vehicle_Rental_Management_System
{
    class RentalAgency
    {
        public Vehicle[] Fleet = new Vehicle[50];
        public double TotalRevenue { get; set; }
        public int count { get; set; }
        string vehicleType;
        int carIncrement = 2, truckIncrement = 2, motorCycleIncrement = 2;
        

        //Constructor
        public RentalAgency(double totalRevenue, int vehicleCount)
        {
            this.TotalRevenue = totalRevenue;
            this.count = vehicleCount;
        }
        //Method for adding vehicles
        public void AddVehicle()
        {
            Console.Write("\nEnter the type of vehicle (Car/Truck/Motorcycle): ");
            string vehicleType = (Console.ReadLine()).ToLower();
            if (vehicleType == "car")
            {
                Car car = new Car();
                car.CarDetails();
                Fleet[++count] = car;
                car.vName = "Car_" + carIncrement.ToString();
                carIncrement++;
                CheckAdd("car",car.vName);
            }
            else if (vehicleType == "truck")
            {
                Truck truck = new Truck();
                truck.TruckDetails();
                Fleet[++count] = truck;
                truck.vName = "Truck_" + truckIncrement.ToString();
                truckIncrement++;
                CheckAdd("truck", truck.vName);
            }
            else if (vehicleType == "motorcycle")
            {
                Motorcycle motorcycle = new Motorcycle();
                motorcycle.MotorcycleDetails();
                Fleet[++count] = motorcycle;
                motorcycle.vName = "Motorcycle_" + motorCycleIncrement.ToString();
                motorCycleIncrement++;
                CheckAdd("motorcycle", motorcycle.vName);
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
                    Console.WriteLine("\nSorry, the vehicle is already in rental status, cannot be removed now.");
                }
                else
                {
                    Console.WriteLine($"\nSuccesfully removed {Fleet[index].vName}!");
                    Fleet[index] = null;
                    for (int i = index; i <= count; i++)
                    {
                        Fleet[i] = Fleet[i + 1];
                    }
                    count--;
                }
            }
            else { Console.WriteLine("\nEntered vehicle name is not found, please try again!"); }
            Console.Write("\nDo you want to remove another vehicle? (Yes/No) ");
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
            //Console.WriteLine("\nPlease find the list of available vehicles:\n");
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
            Console.Write("\nDo you want to rent another vehicle? (Yes/No) ");
            if (Console.ReadLine().ToLower() == "yes")
            {
                RentVehicle();
            }
        }

        //Method for displaying all the vehicle details added in fleet
       public void DisplayFleet()
        {
            Console.WriteLine("\nPlease find the list of available vehicles:\n");
            for (int i = 0; i <= count; i++)
            {
                Fleet[i].DisplayDetails();
            }
        }

        //Method for checking with user on consecutive addition of vehicles
        void CheckAdd(string vehicle, string vehicleName)
        {
            Console.WriteLine($"\nNew {vehicle} {vehicleName} added successfully!");
            Console.Write("\nDo you want to add another vehicle (Yes/No)? ");
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