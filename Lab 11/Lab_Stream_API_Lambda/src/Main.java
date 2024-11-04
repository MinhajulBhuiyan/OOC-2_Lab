import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.*;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args)
    {
        List<Employee> employees = readDataFromCSV("D:\\Downloads\\employee_data.csv");

        // Task 2: Filter employees older than 30
        List<Employee> employeesOver30 = employees.stream().filter(employee -> employee.getAge() > 30).collect(Collectors.toList());

        System.out.println("Employees older than 30:");
        employeesOver30.forEach(employee -> System.out.println(employee.getFirstName() + " " + employee.getLastName()));

        // Task 3: Group employees by postal code
        Map<String, List<Employee>> employeesByPostalCode = employees.stream().collect(Collectors.groupingBy(Employee::getPostalCode));

        System.out.println("\nEmployees grouped by postal code:");
        employeesByPostalCode.forEach((postalCode, employeeList) ->
        {
            System.out.println("Postal Code: " + postalCode);
            employeeList.forEach(employee -> System.out.println(employee.getFirstName() + " " + employee.getLastName()));
        });

        // Task 4: Calculate average remuneration
        double averageRemuneration = employees.stream()
                .mapToDouble(Employee::getRemuneration)
                .average()
                .orElse(0);

        System.out.println("\nAverage remuneration: " + averageRemuneration);

        // Task 5: Find the employee with the highest remuneration
        Optional<Employee> highestRemunerationEmployee = employees.stream()
                .max(Comparator.comparing(Employee::getRemuneration));

        if (highestRemunerationEmployee.isPresent())
        {
            Employee highestRemuneration = highestRemunerationEmployee.get();
            System.out.println("Employee with the highest remuneration: " + highestRemuneration.getFirstName() + " " + highestRemuneration.getLastName());
        }
        else
        {
            System.out.println("No employee found.");
        }

        // Task 6: Check if at least one employee has the designation "Manager"
        boolean hasManager = employees.stream()
                .anyMatch(employee -> "Manager".equals(employee.getDesignation()));

        if (hasManager)
        {
            System.out.println("At least one employee has the designation 'Manager'.");
        }
        else
        {
            System.out.println("No employee has the designation 'Manager'.");
        }

        // Task 7: Sorting employees by age in descending order
        Collections.sort(employees, Comparator.comparingInt(Employee::getAge).reversed());
        System.out.println("\nEmployees sorted by age in descending order:");
        employees.forEach(employee -> System.out.println(employee.getFirstName() + " " + employee.getLastName() + " - Age: " + employee.getAge()));

        // Task 8: Finding the youngest employee using the min operation
        Employee youngestEmployee = employees.stream()
                .min(Comparator.comparingInt(Employee::getAge))
                .orElse(null);
        System.out.println("\nYoungest Employee: " + youngestEmployee.getFirstName() + " " + youngestEmployee.getLastName());

        // Task 9: Counting employees working in the "Uptown" district
        long uptownEmployeesCount = employees.stream()
                .filter(employee -> "Uptown".equals(employee.getDistrict()))
                .count();
        System.out.println("\nNumber of Employees in Uptown District: " + uptownEmployeesCount);

        // Task 10: Getting distinct postal codes
        List<String> distinctPostalCodes = employees.stream()
                .map(Employee::getPostalCode)
                .distinct()
                .collect(Collectors.toList());
        System.out.println("\nDistinct Postal Codes: " + distinctPostalCodes);

        // Task 11: Total cost of remuneration using the reduce operation
        double totalRemuneration = employees.stream()
                .mapToDouble(Employee::getRemuneration)
                .reduce(0, Double::sum);
        System.out.println("\nTotal Remuneration Cost: " + totalRemuneration);

        // Task 12: Checking if all employees are older than 18
        boolean allAdults = employees.stream()
                .allMatch(employee -> employee.getAge() > 18);
        System.out.println("\nAll Employees Are Adults: " + allAdults);

        // Task 13: Skipping the first 3 employees and collecting the rest
        List<Employee> skippedEmployees = employees.stream()
                .skip(3)
                .collect(Collectors.toList());
        System.out.println("\nEmployees after skipping the first 3:");
        skippedEmployees.forEach(employee -> System.out.println(employee.getFirstName() + " " + employee.getLastName()));

        // Task 14: Average age of employees in the "Downtown" district
        double avgAgeDowntown = employees.stream()
                .filter(employee -> "Downtown".equals(employee.getDistrict()))
                .mapToDouble(Employee::getAge)
                .average()
                .orElse(0);
        System.out.println("\nAverage Age of Employees in Downtown District: " + avgAgeDowntown);

        // Task 15: Displaying the top 3 highest remunerations
        List<Employee> top3HighestRemuneration = employees.stream()
                .sorted(Comparator.comparingDouble(Employee::getRemuneration).reversed())
                .limit(3)
                .collect(Collectors.toList());
        System.out.println("\nTop 3 Highest Remunerations:");
        top3HighestRemuneration.forEach(employee -> System.out.println(employee.getFirstName() + " " + employee.getLastName() + " - Remuneration: " + employee.getRemuneration()));
    }

    private static List<Employee> readDataFromCSV(String filename)
    {
        List<Employee> employees = new ArrayList<>();
        try (BufferedReader br = new BufferedReader(new FileReader(filename)))
        {
            String line;
            boolean firstLine = true; // Flag to skip the first line (header)
            while ((line = br.readLine()) != null)
            {
                if (firstLine)
                {
                    firstLine = false; // Skip the first line (header)
                    continue;
                }
                String[] data = line.split(",");
                if (data.length == 8)
                {
                    Employee employee = new Employee(data[0], data[1], data[2], data[3], data[4], Integer.parseInt(data[5]), data[6], Double.parseDouble(data[7]));
                    employees.add(employee);
                }
                else
                {
                    System.err.println("Skipping invalid data: " + line);
                }
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        return employees;
    }
}
