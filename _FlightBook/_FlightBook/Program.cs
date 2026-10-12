namespace _FlightBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egyik 

            //másik
            Passenger passenger1 = new Passenger("Vendel", 10);
            Passenger passenger2 = new Passenger("Gergő", 25);

            passenger2.AddBag();
            passenger2.AddBag();
            passenger2.AddBag();

            Console.WriteLine($"Passenger 1: {passenger1.Name}, Age: {passenger1.Age}, Bags: {passenger1.BagCount}, Is Child: {passenger1.IsChild()}");
            Console.WriteLine($"Passenger 2: {passenger2.Name}, Age: {passenger2.Age}, Bags: {passenger2.BagCount}, Is Child: {passenger2.IsChild()}");



        }
    }
}
