namespace SmallPlanets.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal DistanceFromSun { get; set; }
        public decimal Mass { get; set; }
        public decimal Diameter { get; set; }
    }
}