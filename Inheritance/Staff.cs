using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Staff:Person
    {
        private string _dept;
        private int _dob;

        public Staff(string name, string id, string address,string dept,int dob) : base(name,id,address)
        {
            this._dept = dept;
            this._dob = dob;
        }
    }
}
