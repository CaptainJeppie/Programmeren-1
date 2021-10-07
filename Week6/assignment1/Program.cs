using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        const double VAT = 0.21;
        static void Main(string[] args)
        {
            //enter price
            Console.Write("Enter a price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Calculate VAT and endPrice
            double VATdisplay = CalculateVAT(price);
            double endprice = VATdisplay + price;

            //Display the end price
            Console.WriteLine($"Price: {price:F2}, VAT: {VATdisplay:F2}, total: {endprice:F2}");
            Console.ReadKey();
        }
        static double CalculateVAT(double price)
        {           
            return VAT * price;
        }
    }
}