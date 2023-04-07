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