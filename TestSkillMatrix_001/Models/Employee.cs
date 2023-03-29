namespace TestSkillMatrix_001.Models
{

    public enum EmployeeStatus
    {
        Active = 0,
        Inacative = 1,
        Osbolete = 2,
    }
    public class Employee
    {
        public int Id { get; set; }
        public string? XMLId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PrefferedName { get; set; }
        public string? JobTitle { get; set; }
        public string? WorkPhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? Pronouns { get; set; }
        public string? WorkPhoneExtension { get; set; }
        public virtual Supervisor? Supervisor { get; set; }
        public string? PhotoUploaded { get; set; }
        public string? PhotoUrl { get; set; }
        public string? CanUploadPhoto { get; set; }
        public EmployeeStatus? Status { get; set; }
        public bool? Valid { get; set; }
        public int? DepartmentId { get; set; }
        public string? Division { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual Department? Department { get; set; }
        //public virtual List<Employee>? Employees { get; set; }
    }
}
