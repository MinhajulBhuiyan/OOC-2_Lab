using lab07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GenerateReport();

            Console.WriteLine("...............");
            //Console.ReadKey();

            EmployeeController controller = new EmployeeController();
            Console.WriteLine(controller.DeleteEmployee("John Doe"));
            Console.WriteLine("...............");
            employee.GenerateReport();
            Console.WriteLine("...............");
            Console.ReadKey();
        }
    }
}
