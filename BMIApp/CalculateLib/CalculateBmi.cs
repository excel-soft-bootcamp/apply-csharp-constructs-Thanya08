using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class CalculateBmi
    {
        private double height,weight,result;
        public double Calculate(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public double calculatebmi()
        {
            return result = weight / height;
        }


    }
}
