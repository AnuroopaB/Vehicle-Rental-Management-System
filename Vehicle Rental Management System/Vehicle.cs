using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicle_Rental_Management_System
{
    //Abstract class
    abstract class Vehicle
    {
        public string Model;
        //get {return Model;} 
        //set {
        //    if (string.IsNullOrWhiteSpace(value))
        //    {
        //        throw new ArgumentException("Name cannot be null or empty.");
        //    }
        //    Model = value; } }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }
        public string vName { get; set; }
        public bool rentalStatus = false;
        //Abstract method
        public abstract void DisplayDetails();

        //Method for getting common vehicle properties
        public void VehicleDetails()
        {
            Console.Write("Enter the model of vehicle: ");
            Model = Console.ReadLine();
            Console.Write("Enter the manufacturer of vehicle: ");
            Manufacturer = Console.ReadLine();
            Console.Write("Enter the year of manufacture: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Enter the rental price per day: ");
            RentalPrice = double.Parse(Console.ReadLine());
        }
    }
}