using System;
using CapEnum.Entities;
using CapEnum.Entities.Enums;
using System.Globalization;

namespace CapEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter department´s name: ");
                string deptName = Console.ReadLine();
                Console.WriteLine("Enter worker data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Level (Junior/Pleno/Senior): ");
                WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
                Console.Write("Base Salary: ");
                double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Department dept = new Department(deptName);
                Worker worker = new Worker(name, level, baseSalary, dept);

                Console.Write("How many contracts to this worker?: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Enter #{i} contract data:");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Value Per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Duration: ");
                    int duration = int.Parse(Console.ReadLine());
                    HourContract contract = new HourContract(date, valuePerHour, duration);   
                    worker.AddContract(contract);
                }

                Console.WriteLine();
                Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                string mountAndYear = Console.ReadLine();

                int month = int.Parse(mountAndYear.Substring(0, 2));
                int year = int.Parse(mountAndYear.Substring(3));

                Console.WriteLine("Name " + worker.Name);
                Console.WriteLine("Department " + worker.Department.Name);
                Console.WriteLine("Income for " + mountAndYear + ": " + worker.Income(year, month));


            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }
    }
}
