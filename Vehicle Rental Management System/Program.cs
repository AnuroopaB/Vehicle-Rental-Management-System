namespace Vehicle_Rental_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Truck truck = new Truck();
            Motorcycle motorcycle = new Motorcycle();
            RentalAgency rentalAgency = new RentalAgency();
            car.DisplayDetails();
        }
    }
}