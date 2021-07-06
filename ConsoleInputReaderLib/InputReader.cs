using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class InputReader
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

        private string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
