using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab07
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double HouseAllowance { get; set; }
        public double TransportAllowance { get; private set; }
        public double CostOfLiving { get; private set; }

        public Employee() { }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public Employee(string name, double basicSalary, string designation)
        {
            Name = name;
            BasicSalary = basicSalary;
            HouseAllowance = basicSalary * 0.4;
            TransportAllowance = 5000;
            CostOfLiving = 1000;
            Designation = designation;
            DateOfJoining = DateTime.Now;
        }

        public Employee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Name = name;
            BasicSalary = basicSalary;
            Bonus = bonus;
            Designation = designation;
            DateOfJoining = dateOfJoining;
        }

        public double getSalary()
        {
            return BasicSalary + HouseAllowance + TransportAllowance + CostOfLiving + Bonus;
        }

        public double CalculateSalary()
        {
            double houseAllowance = 0.4 * BasicSalary;
            double transportAllowance = 5000;
            double costOfLiving = 800;
            return BasicSalary + houseAllowance + transportAllowance + costOfLiving + Bonus;
        }


        public void GenerateReport()
        {
            EmployeeController employeeController = new EmployeeController();
            Console.WriteLine(employeeController.GetAllEmployees().Count);
            string outputPath = @"C:\Users\User\OneDrive\Desktop\xmlfile.xml";

            Console.WriteLine(outputPath);
            GenerateEmployeeXMLReport(employeeController.GetAllEmployees(), outputPath);
        }

        public void GenerateEmployeeXMLReport(List<Employee> employees, string outputPath)
        {
            try
            {
                var xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("EmployeeData",
                        employees.Select(employee => new XElement("Employee",
                            new XElement("Name", employee.Name),
                            new XElement("BasicSalary", employee.BasicSalary),
                            new XElement("Bonus", employee.Bonus),
                            new XElement("Designation", employee.Designation),
                            new XElement("DateOfJoining", employee.DateOfJoining),
                            new XElement("TotalSalary", employee.getSalary())
                        ))
                    )
                );

                xmlDocument.Save(outputPath);

                Console.WriteLine("Employee XML report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating the employee XML report: {ex.Message}");
            }
        }
    }



        public interface IEmployeeRepository
        {
        void HireEmployee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining);
        void HireEmployee(string name, double basicSalary, string designation);
        List<Employee> GetAllEmployees();
        Employee FindEmployee(string name);
        string DeleteEmployee(string name);
        string UpdateEmployee(string name, double newBasicSalary, double newBonus, string newDesignation);
    }


    public class EmployeeController : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeController()
        {
            HireEmployee("John Doe", 5000, 1000, "Engineer", new DateTime(2023, 9, 21));
            HireEmployee("Jane Smith", 6000, 1200, "Manager", new DateTime(2021, 8, 22));
            HireEmployee("Bob", 30000, "Worker");
        }

        public void HireEmployee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Employee employee = new Employee(name, basicSalary, bonus, designation, dateOfJoining);
            employees.Add(employee);
        }

        public void HireEmployee(string name, double basicSalary, string designation)
        {
            Employee employee = new Employee(name, basicSalary, designation);
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }


        public Employee FindEmployee(string name)
        {
            Employee foundEmployee = null;
            foreach (Employee employee in employees)
            {
                if (employee.Name == name)
                {
                    foundEmployee = employee;
                    break;
                }
            }
            return foundEmployee;
        }
       

        public string DeleteEmployee(string name)
        {
            Employee removeEmployee = FindEmployee(name);

            if (removeEmployee != null)
            {
                employees.Remove(removeEmployee);
                return $"{name} has been deleted.";
            }
            else
            {
                return $"Employee with name {name} not found.";
            }
        }

        public string UpdateEmployee(string name, double newBasicSalary, double newBonus, string newDesignation)
        {
            Employee employeeToUpdate = FindEmployee(name);

            if (employeeToUpdate != null)
            {
                employeeToUpdate.BasicSalary = newBasicSalary;
                employeeToUpdate.Bonus = newBonus;
                employeeToUpdate.Designation = newDesignation;
                return $"Employee {name}'s data updated.";
            }
            else
            {
                return $"Employee with name {name} not found.";
            }
        }

    }

}



