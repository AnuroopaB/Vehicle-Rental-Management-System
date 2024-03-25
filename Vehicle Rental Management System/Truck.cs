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
 
        //Overriding Abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine($"{vName}\n--------\nModel\t\t:\t{Model}\nManufacturer\t:\t{Manufacturer}\nYear\t\t:\t{Year}\nRental price\t:\t{RentalPrice}\nCapacity\t:\t{Capacity}\nType of Truck\t:\t{TruckType}\nFour wheel drive:\t{FourWheelDrive}\nRental status\t:\t{rentalStatus}\n");
        }
    }
}
