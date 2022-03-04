using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator Program");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Console.WriteLine(invoiceGenerator.CalculateFare(10.0, 15));
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            Console.WriteLine(invoiceGenerator.CalculateFare(rides).totalFare);
            Console.WriteLine(invoiceGenerator.CalculateFare(rides).averageFare);
            Console.WriteLine(invoiceGenerator.CalculateFare(rides).numberOfRides);
        }
    }
}
