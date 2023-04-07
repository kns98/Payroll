public class Department
{
    public int Number { get; set; }
    public string Name { get; set; }
    public List<Manager> Managers { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DepartmentLocation> Locations { get; set; }
}