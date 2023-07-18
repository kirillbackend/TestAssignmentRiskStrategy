namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int StateId { get; set; }
        public State? State { get; set; }

        public List<Company> Company { get; set; } = new();
    }
}
