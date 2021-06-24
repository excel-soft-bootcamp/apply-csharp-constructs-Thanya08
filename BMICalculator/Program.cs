using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Calculator

    {
        public static Double meter, kg, BMI;
        Calculator(double meter, double kg)
        {
            BMI = kg / meter;
            if (BMI < 18.5) { Console.WriteLine("underweight"); }
            else if (BMI >= 25) { Console.WriteLine("overweight"); }
        }

static void Main(string[] args)
        {
                Console.WriteLine("Enter height");
                meter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter weight");
                kg = Convert.ToDouble(Console.ReadLine());
            Calculator ob1 = new Calculator(meter, kg);
            }
        }
    }

