using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string value ="865";
            //    int numeric;
            //    bool isTrue = int.TryParse(value, out numeric);
            //    if (isTrue)
            //    {
            //        Console.WriteLine("The Integer value is " + numeric);
            //        Console.ReadKey();
            //    }
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();  
            //}
            string value = "888";
            double numeric;
            try
            {

                numeric = Convert.ToDouble(value);
                Console.WriteLine("Converted '{0}' to {1}.", value, numeric);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", value);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", value);
            }
        }
    }
}
