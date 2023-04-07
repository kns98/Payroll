using static System.Convert;

Console.WriteLine("Hello world ...");
var jan1 = ToDateTime("1/1/2020");
var dec31 = ToDateTime("12/31/2020");

var loc1 = new Location { Name = "HQ", StartDate = jan1, EndDate = dec31 };
var loc2 = new Location { Name = "Branch", StartDate = jan1, EndDate = dec31 };

var dept1 = new Department
{
    Number = 1,
    Name = "Sales",
    StartDate = jan1,
    EndDate = dec31,
    Managers = new List<Manager>
    {
        new() { EmployeeNumber = 1, StartDate = jan1, EndDate = dec31 }
    },
    Locations = new List<DepartmentLocation>
    {
        new() { Location = loc1 }
    }
};

var dept2 = new Department
{
    Number = 2,
    Name = "Marketing",
    StartDate = jan1,
    EndDate = dec31,
    Managers = new List<Manager>
    {
        new() { EmployeeNumber = 2, StartDate = jan1, EndDate = dec31 }
    },
    Locations = new List<DepartmentLocation>
    {
        new() { Location = loc2 }
    }
};

var proj1 = new Project
{
    Number = 1,
    Names = new List<Name>
    {
        new() { Value = "Project 1", StartDate = jan1, EndDate = dec31 }
    },
    Details = "Details for Project 1",
    StartDate = jan1,
    EndDate = dec31,
    Budgets = new List<Budget>
    {
        new() { Value = "10000", StartDate = jan1, EndDate = dec31 }
    },
    Departments = new List<Department>
    {
        dept1
    }
};

var proj2 = new Project
{
    Number = 2,
    Names = new List<Name>
    {
        new() { Value = "Project 2", StartDate = jan1, EndDate = dec31 }
    },
    Details = "Details for Project 2",
    StartDate = jan1,
    EndDate = dec31,
    Budgets = new List<Budget>
    {
        new() { Value = "20000", StartDate = jan1, EndDate = dec31 }
    },
    Departments = new List<Department>
    {
        dept1,
        dept2
    }
};

var emp1 = new SalariedEmployee
{
    EmployeeNumber = 1,
    Name = "John Smith",
    Birthday = new DateTime(1985, 1, 1),
    StartDate = jan1,
    EndDate = dec31,
    Salaries = new List<Salary>
    {
        new() { Value = 50000, StartDate = jan1, EndDate = dec31 }
    },
    DepartmentEmployees = new List<DepartmentEmployee>
    {
        new() { Department = dept1, StartDate = jan1, EndDate = dec31 }
    },
    ProjectEmployees = new List<ProjectEmployee>
    {
        new() { Project = proj1, StartDate = jan1, EndDate = dec31, DeliveryDate = dec31 }
    }
};

//hourly tbd