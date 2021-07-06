using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLib
{
    public class ValidationBmi
    {
        public string BmiValidate(double bmiValue)
        {
            if (bmiValue < 18.5)
            {
                return "Underweight";
            }
            else if (bmiValue >= 25)
            {
                return "Overweight";
            }
            else
            {
                return "healthy";
            }
        }
    }
}
