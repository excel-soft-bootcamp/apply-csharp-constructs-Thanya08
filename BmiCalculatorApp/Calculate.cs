using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorApp
{
    class Calculate
    {
        private double height, weight, result;
        public double SetHeight
        {
            set
            {
                this.height = value;
            }
        }

        public double SetWeight
        {
            set
            {
                this.weight = value;
            }
        }
        public double calculate()
        {
            return result = weight / height;
        }




        public void validate(double Bmivalue)
        {
            if (Bmivalue < 18.5) { Console.WriteLine("Underweight"); }
            else if (Bmivalue >= 25) { Console.WriteLine("Overweight"); }
        }

    }
}

