using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee: Employee
    {
        private int noOfDays;
        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private double ratePerDay;
        public double RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }

        public Trainee()
        {

        }

        public Trainee(string name, string address, int noOfDays, double ratePerDay): base(name, address)
        {
            NoOfDays = noOfDays;
            RatePerDay = ratePerDay;
            
        }

        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;   
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNo of Days is {NoOfDays}\nRate per Day is {RatePerDay}\nNet Salary is {CalculateSalary()}";
        }
    }
}
