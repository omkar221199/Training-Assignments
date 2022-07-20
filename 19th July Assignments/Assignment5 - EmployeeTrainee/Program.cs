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
            int confirmEmployeeNo = 1;
            int traineeNo = 1001;
            List<ConfirmEmployee> confirmEmployees = new List<ConfirmEmployee>();
            List<Trainee> trainee = new List<Trainee>();
            do
            {
                Console.WriteLine("\n1.Display All Employees\n2.Insert Confirm Employee\n" +
                    "3.Insert Trainee\n4.Delete Employee by no\n5.Display Employee by No\n6.Enter 6 to exit\n");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < confirmEmployees.Count; i++)
                        {
                            Console.WriteLine($"\nName: {confirmEmployees[i].Name} Address: {confirmEmployees[i].Address} Salary: {confirmEmployees[i].CalculateSalary()} Designation: {confirmEmployees[i].Designation}");
                        }
                        for (int i = 0; i < trainee.Count; i++)
                        {
                            Console.WriteLine($"\nName: {trainee[i].Name} Address: {trainee[i].Address} Salary: {trainee[i].CalculateSalary()} ");
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
                            Console.WriteLine("Enter employee designation: ");
                            string designation = Console.ReadLine();
                            confirmEmployees.Add(new ConfirmEmployee(confirmEmployeeNo, name, address, basic, designation));
                            confirmEmployeeNo++;
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
                        trainee.Add(new Trainee(traineeNo, traineeName, traineeAddress, noOfDays, ratePerDay));
                        traineeNo++;
                        break;

                    case 4:
                        Console.WriteLine("\nEnter Employee No: ");
                        int empNo = Convert.ToInt32(Console.ReadLine());
                        if (empNo < 1000)
                        {
                            for (int i = 0; i <= empNo - 1; i++)
                            {
                                if (confirmEmployees[i].EmpNo == empNo)
                                {
                                    confirmEmployees.Remove(confirmEmployees[i]);
                                    Console.WriteLine("Record Deleted...");
                                }
                                else
                                {
                                    Console.WriteLine("There is no employee having employee no {0}", empNo);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= empNo - 1001; i++)
                            {
                                if (trainee[i].EmpNo == empNo)
                                {
                                    trainee.Remove(trainee[i]);
                                    Console.WriteLine("Record Deleted...");
                                }
                                else
                                {
                                    Console.WriteLine("There is no trainee having trainee no {0}", empNo);
                                }
                            }
                        }

                        break;

                    case 5:
                        Console.WriteLine("\nEnter Employee No: ");
                        int empNumber = Convert.ToInt32(Console.ReadLine());
                        if (1 <= empNumber && empNumber <= 1000)
                        {
                            foreach (var ce in confirmEmployees)
                            {
                                if (ce.EmpNo == empNumber)
                                {
                                    Console.WriteLine(ce.ToString());
                                }
                            }
                        }
                        else
                        {
                            foreach (var tr in trainee)
                            {
                                if (tr.EmpNo == empNumber)
                                {
                                    Console.WriteLine(tr.ToString());
                                }
                            }
                        }
                        break;
                }
            } while (choice < 6);
        }
    }
}
