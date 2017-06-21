namespace PlanetAPI.Helpers
{
    public class PlanetInformation
    {
        public static string GetPlanetDiameter(string planet)
        {
            string result = string.Empty;

            switch (planet.ToLower())
            {
                case "mercury":
                    result = "4,879 km";
                    break;

                case "venus":
                    result = "12,104 km";
                    break;

                case "earth":
                    result = "12,742 km";
                    break;

                case "mars":
                    result = "6,779 km";
                    break;

                case "jupiter":
                    result = "139, 822 km";
                    break;

                case "saturn":
                    result = "116,464 km";
                    break;

                case "uranus":
                    result = "50,724 km";
                    break;

                case "neptune":
                    result = "49,244 km";
                    break;

                case "pluto":
                    result = "2,374 km";
                    break;
            }

            return result;
        }

        public static string GetDistanceFromSun(string planet)
        {
            string result = string.Empty;

            switch (planet.ToLower())
            {
                case "mercury":
                    result = "57.91 million km";
                    break;

                case "venus":
                    result = "108.2 million km";
                    break;

                case "earth":
                    result = "149.6 million km";
                    break;

                case "mars":
                    result = "227.9 million km";
                    break;

                case "jupiter":
                    result = "778.5 million km";
                    break;

                case "saturn":
                    result = "1.429 billion km";
                    break;

                case "uranus":
                    result = "2.871 billion km";
                    break;

                case "neptune":
                    result = "4.498 billion km";
                    break;

                case "pluto":
                    result = "3.67 billion miles";
                    break;
            }

            return result;
        }

        public static string GetMass(string planet)
        {
            string result = string.Empty;

            switch (planet.ToLower())
            {
                case "mercury":
                    result = "3.285 × 10^23 kg";
                    break;

                case "venus":
                    result = "4.867 × 10^24 kg";
                    break;

                case "earth":
                    result = "5.972 × 10^24 kg";
                    break;

                case "mars":
                    result = "6.39 × 10^23 kg";
                    break;

                case "jupiter":
                    result = "71.898 × 10^27 kg";
                    break;

                case "saturn":
                    result = "5.683 × 10^26 kg";
                    break;

                case "uranus":
                    result = "8.681 × 10^25 kg";
                    break;

                case "neptune":
                    result = "1.024 × 10^26 kg";
                    break;

                case "pluto":
                    result = "1.30900 × 10^22 kg";
                    break;
            }

            return result;
        }

        public static string GetAdditionalInformation(string planet)
        {
            string result = string.Empty;

            switch (planet.ToLower())
            {
                case "mercury":
                    result = "Mercury is the smallest and innermost planet in the Solar System. Its orbital period is less than any other planet in the Solar System. Seen from Earth, it appears to move around its orbit in about 116 days. It has no known natural satellites.";
                    break;

                case "venus":
                    result = "Venus is the second planet from the Sun, orbiting it every 224.7 Earth days. It has the longest rotation period of any planet in the Solar System and rotates in the opposite direction to most other planets. It has no natural satellite.";
                    break;

                case "earth":
                    result = "Earth is the third planet from the Sun, the densest planet in the Solar System, the largest of the Solar System's four terrestrial planets, and the only astronomical object known to harbor life.";
                    break;

                case "mars":
                    result = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, after Mercury.";
                    break;

                case "jupiter":
                    result = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a giant planet with a mass one-thousandth that of the Sun, but two and a half times that of all the other planets in the Solar System combined.";
                    break;

                case "saturn":
                    result = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius about nine times that of Earth.";
                    break;

                case "uranus":
                    result = "Uranus is the seventh planet from the Sun. It has the third-largest planetary radius and fourth-largest planetary mass in the Solar System.";
                    break;

                case "neptune":
                    result = "Neptune is the eighth and farthest known planet from the Sun in the Solar System. In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet.";
                    break;

                case "pluto":
                    result = "Pluto's distance from the Sun is 3.67 billion miles. Keep in mind that this distance is an average. Pluto follows a highly elliptical orbit around the Sun. At the closest point of its orbit, called perihelion, Pluto gets to within 4.44 billion km from the Sun.";
                    break;
            }

            return result;
        }
    }
}