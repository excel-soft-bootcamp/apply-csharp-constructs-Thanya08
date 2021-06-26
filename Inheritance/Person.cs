using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person{

        private string _name, _id, _address;
        private int _phone;

        public Person(string name,string id,string address)
        {
            this._name = name;
            this._id = id;
            this._address = address;
        }
        public Person(string name, string id, string address,int phone):this(name,id,address)
        {
            this._phone = phone;
        }

    }
}
