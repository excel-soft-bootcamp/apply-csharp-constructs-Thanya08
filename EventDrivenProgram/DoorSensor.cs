using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    public delegate string DoorAction();
    public class DoorSensor
    {
        public string open()
        { 
            return "door is open";
           
        }

        public string close()
        {
            return "door is closed";
        }
    }
}
