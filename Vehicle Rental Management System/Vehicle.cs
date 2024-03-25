using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    //Abstract class
    abstract class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }
        public string vName { get; set; }
        public bool rentalStatus = false;
        //Abstract method
        public abstract void DisplayDetails();
    }
}