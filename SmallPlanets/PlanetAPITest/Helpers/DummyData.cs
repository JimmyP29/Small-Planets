using PlanetAPI.Models;
using System;

namespace PlanetAPITest.Helpers
{
    public class DummyData
    {
        public static Planet GetTestData(Enum type)
        {
            Planet result = null;
            switch (type.ToString().ToLower())
            {
                case "mercury":
                    result = new Planet()
                    {
                        Name = "Mercury",
                        Diameter = "4,879 km",
                        DistanceFromSun = "57.91 million km",
                        Mass = "3.285 × 10^23 kg",
                        AdditionalInformation = "Mercury is the smallest and innermost planet in the Solar System. Its orbital period is less than any other planet in the Solar System. Seen from Earth, it appears to move around its orbit in about 116 days. It has no known natural satellites."
                    };
                    break;
                case "venus":
                    result = new Planet()
                    {
                        Name = "Venus",
                        Diameter = "12,104 km",
                        DistanceFromSun = "108.2 million km",
                        Mass = "4.867 × 10^24 kg",
                        AdditionalInformation = "Venus is the second planet from the Sun, orbiting it every 224.7 Earth days. It has the longest rotation period of any planet in the Solar System and rotates in the opposite direction to most other planets. It has no natural satellite."
                    };
                    break;
                case "earth":
                    result = new Planet()
                    {
                        Name = "Earth",
                        Diameter = "12,742 km",
                        DistanceFromSun = "149.6 million km",
                        Mass = "5.972 × 10^24 kg",
                        AdditionalInformation = "Earth is the third planet from the Sun, the densest planet in the Solar System, the largest of the Solar System's four terrestrial planets, and the only astronomical object known to harbor life."
                    };
                    break;
                case "mars":
                    result = new Planet()
                    {
                        Name = "Mars",
                        Diameter = "6,779 km",
                        DistanceFromSun = "227.9 million km",
                        Mass = "6.39 × 10^23 kg",
                        AdditionalInformation = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, after Mercury."
                    };
                    break;
                case "jupiter":
                    result = new Planet()
                    {
                        Name = "Jupiter",
                        Diameter = "139, 822 km",
                        DistanceFromSun = "778.5 million km",
                        Mass = "71.898 × 10^27 kg",
                        AdditionalInformation = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a giant planet with a mass one-thousandth that of the Sun, but two and a half times that of all the other planets in the Solar System combined."
                    };
                    break;
                case "saturn":
                    result = new Planet()
                    {
                        Name = "Saturn",
                        Diameter = "116,464 km",
                        DistanceFromSun = "1.429 billion km",
                        Mass = "5.683 × 10^26 kg",
                        AdditionalInformation = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius about nine times that of Earth."
                    };
                    break;
                case "uranus":
                    result = new Planet()
                    {
                        Name = "Uranus",
                        Diameter = "50,724 km",
                        DistanceFromSun = "2.871 billion km",
                        Mass = "8.681 × 10^25 kg",
                        AdditionalInformation = "Uranus is the seventh planet from the Sun. It has the third-largest planetary radius and fourth-largest planetary mass in the Solar System."
                    };
                    break;
                case "neptune":
                    result = new Planet()
                    {
                        Name = "Neptune",
                        Diameter = "49,244 km",
                        DistanceFromSun = "4.498 billion km",
                        Mass = "1.024 × 10^26 kg",
                        AdditionalInformation = "Neptune is the eighth and farthest known planet from the Sun in the Solar System. In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet."
                    };
                    break;
                case "pluto":
                    result = new Planet()
                    {
                        Name = "Pluto",
                        Diameter = "2,374 km",
                        DistanceFromSun = "3.67 billion miles",
                        Mass = "1.30900 × 10^22 kg",
                        AdditionalInformation = "Pluto's distance from the Sun is 3.67 billion miles. Keep in mind that this distance is an average. Pluto follows a highly elliptical orbit around the Sun. At the closest point of its orbit, called perihelion, Pluto gets to within 4.44 billion km from the Sun."
                    };
                    break;
            }
            return result;
        }
    }
}
