using System;

public class Employee
{
    public static int NumberOfEmployees;
    private static int counter;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public static int Counter
    {
        get { return counter; }
    }

    public Employee()
    {
        counter = ++counter + NumberOfEmployees;
    }
}

class TestEmployee
{
    static void Main()
    {
        Employee.NumberOfEmployees = 107;
        Employee e1 = new Employee();
        e1.Name = "Claude Vige";

        System.Console.WriteLine("Employee number: {0}", Employee.Counter);
        System.Console.WriteLine("Employee name: {0}", e1.Name);
    }
}