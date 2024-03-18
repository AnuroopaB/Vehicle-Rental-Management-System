namespace Vehicle_Rental_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalAgency rentalAgency = new RentalAgency();
            Console.WriteLine("Welcome to Virtual Rental Management System\n**********************************");
            //    Loop:
                Console.Write("\nEnter 1 to select a vehicle for rent\nEnter 2 to add a vehicle to system\nEnter 3 to remove a vehicle from system\nEnter any other key to Exit\n\nEnter your selection: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        rentalAgency.RentVehicle();
                        break;  
                    case 2:
                        rentalAgency.AddVehicle();
                        break;
                    case 3:
                        rentalAgency.RemoveVehicle();
                        break;
                    default:
                        Console.WriteLine("\nPlease select a valid option!");
                        break;
                }
        }
    }
}