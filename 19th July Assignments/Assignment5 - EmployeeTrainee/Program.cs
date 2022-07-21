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
            int choice;         
            List<Employee> employees = new List<Employee>();

            do
            {
                Console.WriteLine("\n1.Display All Employees\n2.Insert Confirm Employee\n" +
                    "3.Insert Trainee\n4.Delete Employee by no\n5.Display Employee by No\n6.Enter 6 to exit\n");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < employees.Count; i++)
                        {
                            Console.WriteLine($"\nName: {employees[i].Name} Address: {employees[i].Address} Salary: {employees[i].CalculateSalary()} ");
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("\nEnter employee name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter employee address: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter employee basic salary: ");
                        try
                        {
                            double basic = Convert.ToDouble(Console.ReadLine());
                            if (basic < 5000)
                            {
                                throw new MinimumBasicSalaryException("Minimum basic salary must be 5000.");
                            }
                            Console.WriteLine("Enter employee designation: ");
                            string designation = Console.ReadLine();
                            employees.Add(new ConfirmEmployee(name, address, basic, designation));
                            
                        }
                        catch (MinimumBasicSalaryException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nEnter trainee name: ");
                        string traineeName = Console.ReadLine();
                        Console.WriteLine("Enter trainee address: ");
                        string traineeAddress = Console.ReadLine();
                        Console.WriteLine("Enter trainee's no of days: ");
                        int noOfDays = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter trainee's rate per day: ");
                        double ratePerDay = Convert.ToDouble(Console.ReadLine());
                        employees.Add(new Trainee(traineeName, traineeAddress, noOfDays, ratePerDay));
                        break;

                    case 4:
                        Console.WriteLine("\nEnter Employee No: ");
                        int empNo = Convert.ToInt32(Console.ReadLine());
                        bool flag=false;
                        for (int i = 0; i < employees.Count; i++)
                        {
                            
                            if (employees[i].EmpID == empNo)
                            {
                                flag = true;
                                employees.Remove(employees[i]);
                                Console.WriteLine("Record Deleted...");
                                break;
                            }
                            
                        }
                        if (!flag) 
                        { Console.WriteLine("There is no record with employee no {0}", empNo); }
                        break;

                    case 5:
                        Console.WriteLine("\nEnter Employee No: ");
                        int empNumber = Convert.ToInt32(Console.ReadLine());
                        bool flag1 = true;
                        for (int i = 0; i < employees.Count; i++)
                        {
                            
                            if (employees[i].EmpID == empNumber)
                            {
                                flag1 = false;
                                Console.WriteLine(employees[i]);
                                break;
                            }

                        }
                        if (flag1)
                        {
                            Console.WriteLine("There is no record with employee no {0}", empNumber);
                        }
                        break;
                }
            } while (choice < 6);
        }
    }
}
