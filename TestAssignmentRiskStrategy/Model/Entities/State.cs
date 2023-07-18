namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> Cityes { get; set; }
    }
}
