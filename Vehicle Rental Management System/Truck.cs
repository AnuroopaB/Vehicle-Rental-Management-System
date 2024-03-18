using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Truck : Vehicle
    {
        public float Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }
        public Truck(string model, string manufacturer, int year, double rentalPrice)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
            this.RentalPrice = rentalPrice;
            Console.Write("\nEnter the capacity in litres: ");
            this.Capacity = float.Parse(Console.ReadLine());
            Console.Write("\nEnter the type of truck: ");
            this.TruckType = Console.ReadLine();
            Console.Write("\nIs it four wheel drive? (Yes/No) ");
            string check = (Console.ReadLine()).ToLower();
            if (check == "yes")
            {
                this.FourWheelDrive = true;
            }
            else
            {
                this.FourWheelDrive = false;
            }
        }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}.\nManufacturer is {Manufacturer}.\nYear is {Year}\nRental price is {RentalPrice}.\nCapacity is {Capacity}.\nType of Truck is {TruckType}.\n Four wheel drive: {FourWheelDrive}.\n");
        }
    }
}
