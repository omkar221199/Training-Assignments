using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee()
        {

        }

        public Employee(string name, string address)
        {
            Name = name;
            Address = address;    
        }

        public abstract double CalculateSalary();
    }
}

