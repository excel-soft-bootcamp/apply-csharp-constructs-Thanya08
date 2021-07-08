using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            void validateDisplay(double Bmivalue)
            {
                ValidationLib.ValidationBmi _validate = new ValidationLib.ValidationBmi();
                string message = _validate.BmiValidate(Bmivalue);

                ConsoleDisplayLib.Display resultdisplay = new ConsoleDisplayLib.Display();
                resultdisplay.ConsoleDisplay(message);
                Console.ReadKey();
            }
        choiceInput:
            Console.WriteLine("choice 1-->input method choice 2--> file read method");
            Console.WriteLine("enter your choice");
            try
            {
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        ConsoleInputReaderLib.InputReader reader = new ConsoleInputReaderLib.InputReader();
                        CalculateLib.CalculateBmi value = new CalculateLib.CalculateBmi();
                        double Bmivalue = value.bmicalculate(reader.GetHeight(), reader.GetWeight());
                        validateDisplay(Bmivalue);
                        break;
                    case 2:
                        string line;
                        System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\thanya.n\source\repos\Examples\BMIApp\patientdetails.txt");
                        

                        while ((line = file.ReadLine()) != null)
                        {
                            string[] lineArray = { };
                            lineArray = line.Split(',');
                            string name = lineArray[0];
                            double height = double.Parse(lineArray[1]);
                            double weight = double.Parse(lineArray[2]);
                            Console.WriteLine("name="+name +" height="+height+" weight="+weight+" result: ");
                            CalculateLib.CalculateBmi value1 = new CalculateLib.CalculateBmi();
                            double Bmivalue2 = value1.bmicalculate(height, weight);
                            validateDisplay(Bmivalue2);
                        }
                        break;
                        file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Choice Must be a Number");
                goto choiceInput;
            }
        }
    }
}

