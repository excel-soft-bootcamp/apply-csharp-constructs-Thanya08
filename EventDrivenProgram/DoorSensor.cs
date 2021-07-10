using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    public delegate void DoorActionHandler(string status);
    public class DoorSensor
    {
        string status;
        public event DoorActionHandler OnDoorStatusChanged;
        public void Open()
        {
            status = "opened";
            this.Notify();

        }

        public void Close()
        {
            status = "closed";
            this.Notify();
        }

        void Notify()
        {
            string message = $"{this.status} and Time : {System.DateTime.Now.ToString()}";
            OnDoorStatusChanged.Invoke(message);
        }

    }
}
