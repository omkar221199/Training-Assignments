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

        public static int EmpCounter=1;
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

        public int EmpID { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string address)
        {
            Name = name;
            Address = address;
            EmpID = EmpCounter++;
        }

        public override string ToString()
        {
            return String.Format($"Name is: {Name}\nAddress is: {Address}");
        }
        public abstract double CalculateSalary();
    }
}

