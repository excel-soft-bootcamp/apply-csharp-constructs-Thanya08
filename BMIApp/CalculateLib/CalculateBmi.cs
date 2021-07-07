using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class CalculateBmi
    {
      
        public double bmicalculate(double height, double weight)
        {
            double result = weight / height;
            return result;
        }


    }
}
