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
            Console.WriteLine("Enter your height in meter:");
            double height = Convert.ToDouble((Console.ReadLine()));            
            return height;
        }
        public double GetWeight()
        {
            Console.WriteLine("Enter your weight in meter:");
            double weight = Convert.ToDouble((Console.ReadLine()));  
            return weight;
        }

      
    }
}
