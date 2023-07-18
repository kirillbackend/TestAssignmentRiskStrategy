namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class Notes
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
