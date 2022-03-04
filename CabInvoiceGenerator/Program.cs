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
            Console.ReadLine();
        }
    }
}
