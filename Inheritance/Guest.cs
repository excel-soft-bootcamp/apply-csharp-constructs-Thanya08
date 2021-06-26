using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Guest:Person
    {
        private int _visitorNumber;

        public Guest(string name, string id, string address,int visitorNumber) : base(name,id,address)
        {
            this._visitorNumber = visitorNumber;
        }
    }
}

