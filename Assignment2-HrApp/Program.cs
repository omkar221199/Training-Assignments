using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HrApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter employee basic salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter employee designation: ");
            string designation = Console.ReadLine();
            ConfirmEmployee confirmEmployee = new ConfirmEmployee(name, address, basic, designation);
            Console.WriteLine("Net Salary of the employee is {0}", confirmEmployee.CalculateSalary());

            Console.WriteLine();

            Console.WriteLine("Enter employee name: ");
            string traineeName = Console.ReadLine();
            Console.WriteLine("Enter employee address: ");
            string traineeAddress = Console.ReadLine();
            Console.WriteLine("Enter trainee's no of days: ");
            int noOfDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter trainee's rate per day: ");
            double ratePerDay = Convert.ToDouble(Console.ReadLine());
            Trainee trainee = new Trainee(traineeName, traineeAddress, noOfDays, ratePerDay);
            Console.WriteLine("Net Salary of the trainee is {0}", trainee.CalculateSalary());

            Console.ReadLine();

        }
    }
}
