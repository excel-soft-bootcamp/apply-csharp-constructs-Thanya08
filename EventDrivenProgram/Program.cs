using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _securitySystem = new SecuritySystem();
            DoorActionHandler doorStatusChangeHandler = new DoorActionHandler(_securitySystem.Update);


            DoorSensor doorSensor = new DoorSensor();
            doorSensor.OnDoorStatusChanged += doorStatusChangeHandler;
            doorSensor.Open();
            doorSensor.Close();


        }
    }
}
