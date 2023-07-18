using System.Collections.Specialized;

namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string CityId { get; set; }
        public City? City { get; set; }

        public string StateId { get; set; }
        public State? State { get; set; }

        public List<Employee> Employees { get; set; } = new();
        public List<History> History { get; set; } = new();
        public List<Notes> Notes { get; set; } = new();
    }
}
