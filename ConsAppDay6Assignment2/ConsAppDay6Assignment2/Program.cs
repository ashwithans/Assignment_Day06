using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay6Assignment2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Salary Calculation System");
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.WriteLine("choose any one from the above choices");
            int employeeType = int.Parse(Console.ReadLine());


            switch (employeeType)
            {
                case 1: // HR
                    Console.Write("Enter working hours: ");
                    int workingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    int workingDays = int.Parse(Console.ReadLine());
                    double salary = CalculateSalary(workingHours, workingDays);
                    Console.WriteLine("Monthly salary for HR: " + salary);
                    break;

                case 2: // Admin
                    Console.Write("Enter working hours: ");
                    int adminWorkingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    int adminWorkingDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of project handles: ");
                    int projectHandles = int.Parse(Console.ReadLine());
                    salary = CalculateSalary(adminWorkingHours, adminWorkingDays, projectHandles: projectHandles);
                    Console.WriteLine("Monthly salary for Admin: " + salary);
                    break;

                case 3: // Software Developer
                    Console.Write("Enter working hours: ");
                    int devWorkingHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    int devWorkingDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of project handles: ");
                    int devProjectHandles = int.Parse(Console.ReadLine());
                    Console.Write("Enter extras: ");
                    int extras = int.Parse(Console.ReadLine());
                    salary = CalculateSalary(devWorkingHours, devWorkingDays, devProjectHandles, extras);
                    Console.WriteLine("Monthly salary for Software Developer: " + salary);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }

        static double CalculateSalary(int workingHours, int workingDays, int projectHandles = 0, int extras = 0)
        {
            return workingHours * workingDays * 100 + projectHandles * 3000 + extras * 2000;
        }
        
       
    }
}
