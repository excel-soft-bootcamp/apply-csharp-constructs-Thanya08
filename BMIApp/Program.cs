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
            ConsoleInputReaderLib.InputReader reader = new  ConsoleInputReaderLib.InputReaderb();
           
            CalculateLib.CalculateBmi value = CalculateLib.CalculateBmi();
            double Bmivalue = value.bmicalculate(reader.GetHeight(), reader.GetWeight());

            ValidationLib.ValidationBmi _validate = new ValidationLib.ValidationBmi();
            string message = _validate.BmiValidate(Bmivalue);

             ConsoleDisplayLib.Display resultdisplay = new ConsoleDisplayLib.Display();
            resultdisplay.ConsoleDisplay(message);
            Console.ReadKey();
        }
    }
}
