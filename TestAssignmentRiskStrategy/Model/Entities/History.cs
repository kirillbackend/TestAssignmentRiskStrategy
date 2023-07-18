namespace TestAssignmentRiskStrategy.Model.Entities
{
    public class History
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
