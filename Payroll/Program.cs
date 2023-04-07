using System;
using System.Collections.Generic;


Console.WriteLine("Hello world ...");

public class Location
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class DepartmentLocation
{
    public Location Location { get; set; }
}

public class Department
{
    public int Number { get; set; }
    public string Name { get; set; }
    public List<Manager> Managers { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DepartmentLocation> Locations { get; set; }
}

public class Manager
{
    public int EmployeeNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Name
{
    public string Value { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Budget
{
    public string Value { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Project
{
    public int Number { get; set; }
    public List<Name> Names { get; set; }
    public string Details { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Budget> Budgets { get; set; }
    public List<Department> Departments { get; set; }
}

public class DepartmentEmployee
{
    public Department Department { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class ProjectEmployee
{
    public Project Project { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime DeliveryDate { get; set; }
}

public class Grade
{
    public string Value { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Employee
{
    public int EmployeeNumber { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public List<Grade> Grades { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DepartmentEmployee> DepartmentEmployees { get; set; }
    public List<ProjectEmployee> ProjectEmployees { get; set; }
}

public class Salary
{
    public int Value { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Hourly
{
    public int PayScale { get; set; }
    public int Hour { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class SalariedEmployee : Employee
{
    public List<Salary> Salaries { get; set; }
}

public class HourlyEmployee : Employee
{
    public List<Hourly> Hourlies { get; set; }
}
