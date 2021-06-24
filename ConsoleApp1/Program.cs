using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        


        static void Main(string[] args)
        {
           
            double meter,kg,BMI;

            Console.WriteLine("Enter height");
            meter = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter weight");
            kg = Convert.ToSingle(Console.ReadLine());
            BMI = kg / meter;
            if (BMI < 18.5) { Console.WriteLine("overweight"); }
            else if (BMI >= 25) { Console.WriteLine("healthy"); }
            

        }
    }
}
