using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgram
{
    public class SecuritySystem
    {
        public void Notify(string status)
        {
            Console.WriteLine("Door is" +status+ "at" +DateTime.Now.ToString());
        }
    }
}
