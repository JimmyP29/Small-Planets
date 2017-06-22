using PlanetAPI.Models;
using System;
using System.Drawing;

namespace PlanetAPI.Helpers
{
    public class PlanetBuilder
    {
        public Planet Create(Enum type)
        {
            return new Planet
            {
                Name = type.ToString(),
                Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(GetImage(type))),
                Diameter = GetDiameter(type),
                DistanceFromSun = GetDistanceFromSun(type),
                Mass = GetMass(type),
                AdditionalInformation = GetAdditionalInformation(type)
            };
        }

        private Bitmap GetImage(Enum type)
        {
            return PlanetImage.GetPlanetImage(type);
        }

        private string GetDiameter(Enum type)
        {
            return PlanetInformation.GetPlanetDiameter(type);
        }

        private string GetDistanceFromSun(Enum type)
        {
            return PlanetInformation.GetDistanceFromSun(type);
        }

        private string GetMass(Enum type)
        {
            return PlanetInformation.GetMass(type);
        }

        private string GetAdditionalInformation(Enum type)
        {
            return PlanetInformation.GetAdditionalInformation(type);
        }
    }
}