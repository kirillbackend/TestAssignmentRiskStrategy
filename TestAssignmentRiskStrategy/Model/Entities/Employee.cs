namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public List<Notes> Notes { get; set; }
    }
}
