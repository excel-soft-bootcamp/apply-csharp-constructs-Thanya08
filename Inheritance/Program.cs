using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student _student = new Student("tom","4mh112","mysore","b-ve","aug2020",08-06-1998);
            Teacher _teacher = new Teacher("jane","4vv113","mysore","a+ve", 05-04-1999, "aast prof");
            Staff _staff = new Staff("patrick","4ne032","mysore","accounts",12-02-1989);
            Guest _guest = new Guest("visitor", "4mh23", "mysore", 01);
        }
    }
}
