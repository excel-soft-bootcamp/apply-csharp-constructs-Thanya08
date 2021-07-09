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
            OnDoorStatusChanged.Invoke(this.status);

        }

        public void Close()
        {
            status = "closed";
            OnDoorStatusChanged.Invoke(this.status);
        }

        

    }
}
