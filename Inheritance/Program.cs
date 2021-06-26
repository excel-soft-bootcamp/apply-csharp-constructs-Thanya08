using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class CollegeMember
    {
        private string _name,_validity,_signature;
       

        public CollegeMember(string name)
        {
            this._name = name;
        }

        public CollegeMember(string name,string validity):this(name)
        {
            this._validity = validity;
        }

        public CollegeMember(string name, string validity,string signature) : this(name,validity)
        {
            this._signature = signature;
        }
    }
    public class Students : CollegeMember{
        private string _usn;
        private int _dob;
        public void Internals() { }
        public void Exams() { }
        public void Sports() { }

        public Students(string usn,int dob, string name, string validity, string signature) :base(name,validity,signature)
        {
            this._usn = usn;
            this._dob = dob;
        }
        
        
        

    }

    public class Teachers : CollegeMember{
        private string _designation;
        private int _dob;
        public void Teach() { }
        public void Mentoring() { }
        public void Invigilate() { }
        public void Evaluate() { }

        public Teachers(string designation,int dob, string name, string validity, string signature) : base(name, validity, signature)
        {
            this._designation = designation;
            this._dob = dob;
        }
    }

    public class Staff:CollegeMember
    {
        private string _dept;
        private int _dob;
        public void Administrate() { }
        public void Clean() { }

        public Staff(string dept,int dob, string name, string validity, string signature) : base(name, validity, signature)
        {
            this._dept = dept;
            this._dob = dob;
        }

    }

    public class Guest:CollegeMember
    {
        private int _visitorNumber;
        public void Monitor() { }
        public void Meeting() { }

        public Guest(int visitorNumber, string name, string validity,string signature) : base(name, validity, signature)
        {
            this._visitorNumber = visitorNumber;
        }
    }
        

         

    class Program
    {
        static void Main(string[] args)
        {
            Students _students = new Students("4mh16is115", 21-12-1998, "tom", "21aug2020", "principal");
            Teachers _teachers = new Teachers("asst prof", 08-06-1998, "markwood", "21aug2020", "principal");
            Staff _staff = new Staff("accounts",12-02-1989,"patrickjane", "21aug2020", "principal");
            Guest _guest = new Guest(01, "abc", "21aug2020", "principal");
        }
    }
}
