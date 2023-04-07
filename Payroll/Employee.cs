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