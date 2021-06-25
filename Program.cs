using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputReader reader = new InputReader();
            double height = reader.GetHeight();
            double weight = reader.GetWeight();

            Calculate obj = new Calculate();
            obj.SetHeight = height;
            obj.SetWeight = weight;
            double result = obj.calculate();
            obj.validate(result);

        }
    }
}
