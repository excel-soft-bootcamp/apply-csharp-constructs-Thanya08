using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher:Person
    {
        private string _designation,_bloodGroup;
        private int _dob;

        public Teacher(string name, string id, string address, string bloodGroup,int dob,string designation) : base(name, id, address)
        {
            this._designation = designation;

        }
    }
}