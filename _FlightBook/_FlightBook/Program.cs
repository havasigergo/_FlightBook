namespace _FlightBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egyik 

            //másik

            passenger2.AddBag();
            passenger2.AddBag();
            passenger2.AddBag();

            Console.WriteLine($"Passenger 1: {passenger1.Name}, Age: {passenger1.Age}, Bags: {passenger1.BagCount}, Is Child: {passenger1.IsChild()}");
            Console.WriteLine($"Passenger 2: {passenger2.Name}, Age: {passenger2.Age}, Bags: {passenger2.BagCount}, Is Child: {passenger2.IsChild()}");



        }
    }
}
