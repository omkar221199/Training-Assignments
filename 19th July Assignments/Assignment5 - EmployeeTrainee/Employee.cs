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

        public int EmpNo { get; private set; }

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

        public Employee(int empno, string name, string address)
        {
            EmpNo = empno;
            Name = name;
            Address = address;    
        }

        public override string ToString()
        {
            return String.Format($"Name is: {Name}\nAddress is: {Address}");
        }
        public abstract double CalculateSalary();
    }
}

