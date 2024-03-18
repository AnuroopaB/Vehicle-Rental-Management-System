using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Vehicle_Rental_Management_System
{
    class RentalAgency
    {
        public Vehicle[] Fleet;
        public int TotalRevenue {  get; set; }
        public string vehicleType, model, manufacturer;
        int year;
        double rentalPrice;
        public void AddVehicle()
        {
            Console.Write("\nEnter the type of vehicle (Car/Truck/Motorcycle): ");
            string vehicleType = (Console.ReadLine()).ToLower();
            if (vehicleType == "car")
            {
                VehicleProperties();
                Car car = new Car(model, manufacturer, year, rentalPrice);

                Console.WriteLine("\nVehicle added successfully!");
            }
            else if (vehicleType == "truck")
            {
                VehicleProperties();
                Truck truck = new Truck(model, manufacturer, year, rentalPrice);
                Console.WriteLine("\nVehicle added successfully!");
            }
            else if(vehicleType == "motorcycle")
            {
                VehicleProperties();
                Motorcycle motorcycle = new Motorcycle(model, manufacturer, year, rentalPrice);
                Console.WriteLine("\nVehicle added successfully!");
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
            
        }
        void VehicleProperties()
        {
            Console.Write("\nEnter the model of vehicle: ");
            model = Console.ReadLine();
            Console.Write("\nEnter the manufacturer of vehicle: ");
            manufacturer = Console.ReadLine();
            Console.Write("\nEnter the year of manufacture: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the rental price: ");
            rentalPrice = double.Parse(Console.ReadLine());
        }
    }
}