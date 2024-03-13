using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int RentalPrice { get; set; }
        void DisplayDetails()
        {
        }
    }
}
