using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student:Person
    {
        private string _bloodGroup,_validity;
        private int _dob;

        public Student(string name,string id,string address,string bloodGroup,int dob):base(name,id,address)
        {
            this._bloodGroup = bloodGroup;
            this._dob = dob;
        }
        public Student(string name, string id, string address,string bloodGroup,string validity,int dob) : this(name,id,address,bloodGroup,dob)
        {
            this._validity = validity;
          
        }

    }
}
