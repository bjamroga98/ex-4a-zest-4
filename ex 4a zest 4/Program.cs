using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4a_zest_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Console.WriteLine("Total; " + Employee.NumberOfEmployees);

            Console.ReadKey();
        }
        class Human
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }
        class Employee : Human
        {
            public string Position { get; set; }
            public float HourlyRate { get; set; }
            public static int NumberOfEmployees { get; set; }
            public float CalculatePayment(int hoursNumber)
            {
                return hoursNumber * HourlyRate;
            }
            public Employee()
            {
                NumberOfEmployees++;
            }
        }
    }
}
