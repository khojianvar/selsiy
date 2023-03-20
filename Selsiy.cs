using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Selsiy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selsiy: ");
            double selsiy = double.Parse(Console.ReadLine());
            double farengeyt = selsiy * 33.8;
            double kelvin = selsiy * 274.15;
            Console.WriteLine($"{selsiy}-gradus Selsiy = {farengeyt}-farengeytga");
            Console.WriteLine($"{selsiy}-gradus Selsiy = {kelvin}-kelvinga");
            Main(args);
        }
    }
}
