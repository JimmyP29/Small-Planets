namespace SmallPlanets.Models.ViewModels
{
    public class Planet
    {
        //public string Name { get; set; }
        //public byte[] Image { get; set; }
        //public string DistanceFromSun { get; set; }
        //public string Mass { get; set; }
        //public string Diameter { get; set; }

        //public Planet()
        //{
        //    Name = string.Empty;
        //    Image = null;
        //    DistanceFromSun = string.Empty;
        //    Mass = string.Empty;
        //    Diameter = string.Empty;
        //}

        public string Name { get; set; }
        public string Image { get; set; }
        public string DistanceFromSun { get; set; }
        public string Mass { get; set; }
        public string Diameter { get; set; }

        public Planet()
        {
            Name = string.Empty;
            Image = null;
            DistanceFromSun = string.Empty;
            Mass = string.Empty;
            Diameter = string.Empty;
        }
    }
}