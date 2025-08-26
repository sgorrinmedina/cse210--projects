using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123adc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456def");
        sEmployee.SetSalary(60000)

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }
    }

    public static void DisplayEmployeeInformation(Employee employee)
    {
        float pay = employee.GetSalary();
        Console.WriteLine($"{employee.GetName()} will be paid: {pay}");
    }
}