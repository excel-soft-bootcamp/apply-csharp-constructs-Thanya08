using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorApp
{
    class InputReader
    {
        public double GetHeight()
        {
            double height = double.Parse((this.ReadFromConsole("Enter height"));
            return height;
        }
        public double GetWeight()
        {
            double weight = double.Parse((this.ReadFromConsole("Enter Weight"));
            return weight;
        }
    }
}
