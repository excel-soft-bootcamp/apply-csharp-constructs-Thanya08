using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInputReaderLib reader = new ConsoleInputReaderLib();
            double height = reader.GetHeight();
            double weight = reader.GetWeight();

            CalculateLib obj = new CalculateLib(height, weight);
            double Bmivalue = obj.BmiCalculation();

            ValidationLib _validate = new ValidationLib();
            string message = _validate.BmiValidate(Bmivalue);

            ConsoleDisplayLib display = new ConsoleDisplayLib();
            display.ConsoleDisplay(message);
            Console.ReadKey();
        }
    }
}
