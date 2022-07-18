using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private double basic;
        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        private string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public ConfirmEmployee()
        {

        }

        public ConfirmEmployee(string name, string address, double basic, string designation) : base(name, address)
        {
            Basic = basic;
            Designation = designation;
        }

        public override double CalculateSalary()
        {
            double hra, conv, pf, netSalary;
            if (Basic >= 30000)
            {
                hra = 0.3 * Basic;
                conv = 0.3 * Basic;
                pf = 0.1 * Basic;
                netSalary = Basic + hra + conv - pf;
                return netSalary;
            }
            else if (Basic >= 20000)
            {
                hra = 0.2 * Basic;
                conv = 0.2 * Basic;
                pf = 0.1 * Basic;
                netSalary = Basic + hra + conv - pf;
                return netSalary;
            }
            else
            {
                hra = 0.1 * Basic;
                conv = 0.1 * Basic;
                pf = 0.1 * Basic;
                netSalary = Basic + hra + conv - pf;
                return netSalary;
            }
        }
    }
}
