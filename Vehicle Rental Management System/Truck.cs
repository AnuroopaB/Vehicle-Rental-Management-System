using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Model is {Model}\nManufacturer is {Manufacturer}\nYear is {Year}\nRentalPrice is {RentalPrice}\n");
        }
    }
}
