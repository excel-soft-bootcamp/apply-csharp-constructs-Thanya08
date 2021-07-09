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
            SecuritySystem _observer = new SecuritySystem();
            DoorSensor _sensor = new DoorSensor();
            DoorAction _action_open = new DoorAction(_sensor.open);
            DoorAction _action_close = new DoorAction(_sensor.close);
            string open_message = _action_open.Invoke();
            string close_message = _action_close.Invoke();
            _observer.SendMessage(open_message);
            _observer.SendMessage(close_message);
        }
    }
}
