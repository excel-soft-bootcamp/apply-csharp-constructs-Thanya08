using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInputReader reader = new ConsoleInputReader();
            double height = reader.GetHeight();
            double weight = reader.GetWeight();

            Calculate obj = new Calculate();
            obj.SetHeight = height;
            obj.SetWeight = weight;
            double result = obj.calculatebmi();
            obj.validate(result);


        }
    }
}
