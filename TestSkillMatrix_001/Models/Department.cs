namespace TestSkillMatrix_001.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Supervisor> Supervisors { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
