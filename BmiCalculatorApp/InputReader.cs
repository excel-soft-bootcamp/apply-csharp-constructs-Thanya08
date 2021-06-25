using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorApp
{
    class InputReader
    {
        public double GetHeight()
        {
            double height = double.Parse((this.ReadFromConsole("Enter height")));
            return height;
        }
        public double GetWeight()
        {
            double weight = double.Parse((this.ReadFromConsole("Enter Weight")));
            return weight;
        }

        private String ReadFromConsole(String msg)
        {
            Console.WriteLine(msg);
            String input = Console.ReadLine();
            return input;
        }
    }
}
