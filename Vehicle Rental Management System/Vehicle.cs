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
        protected string Model { get; set; }
        protected string Manufacturer { get; set; }
        protected int Year { get; set; }
        protected double RentalPrice { get; set; }
        /*Vehicle(string Model, string Manufacturer, int Year, double RentalPrice)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;  
            this.Year = Year;
            this.RentalPrice = RentalPrice;
        }*/
        //Abstract method
        public abstract void DisplayDetails();
    }
}
