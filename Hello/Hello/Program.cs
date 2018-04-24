using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome vishal.");
            Console.WriteLine("Bhandekar.");

            string result=Program.NameCompare("vishal", "vish");
            Console.WriteLine(result);
            Console.Read();
        }

        public static string NameCompare(string FirstName,string knownAs)
        {
            if(FirstName==knownAs)
            {
                return "";
            }
            else
            {
                return knownAs;
            }           
        }
    }
}
