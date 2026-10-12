namespace _FlightBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egyik 
            Flight flight1 = new Flight("FR123", "London,", 25000, 3);
            Flight flight2 = new Flight("FR122", "New-York,", 15000, 1);


            Passenger passenger3 = new Passenger()

            //másik
            Passenger passenger1 = new Passenger("Vendel", 10);
            Passenger passenger2 = new Passenger("Gergő", 25);

            passenger2.AddBag();
            passenger2.AddBag();
            passenger2.AddBag();

            Console.WriteLine($"Passenger 1: {passenger1.Name}, Age: {passenger1.Age}, Bags: {passenger1.BagCount}, Is Child: {passenger1.IsChild()}");
            Console.WriteLine($"Passenger 2: {passenger2.Name}, Age: {passenger2.Age}, Bags: {passenger2.BagCount}, Is Child: {passenger2.IsChild()}");

            Schedule schedule1 = new Schedule();
            schedule1.AddFlight(flight1);
            schedule1.AddFlight(flight2);

            Flight flight3 = new Flight("FR124", "London,", 20000, 0);
            schedule1.AddFlight(flight3);

            Console.WriteLine($"Number of flights: {schedule1.Flights.Count}");
            Console.WriteLine($"Fully booked flights: {schedule1.FullyBookedCount()}");
            Console.WriteLine($"Free seats to London: {schedule1.FreeSeatsTo("London")}");

        }
    }
}
