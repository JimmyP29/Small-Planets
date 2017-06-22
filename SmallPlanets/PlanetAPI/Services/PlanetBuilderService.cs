using PlanetAPI.Helpers;
using PlanetAPI.Interfaces;
using PlanetAPI.Models;
using System;
using System.Drawing;

namespace PlanetAPI.Services
{
    public class PlanetBuilderService : IPlanetBuilder
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

        public Bitmap GetImage(Enum type)
        {
            return PlanetImage.GetPlanetImage(type);
        }

        public string GetDiameter(Enum type)
        {
            return PlanetInformation.GetPlanetDiameter(type);
        }

        public string GetDistanceFromSun(Enum type)
        {
            return PlanetInformation.GetDistanceFromSun(type);
        }

        public string GetMass(Enum type)
        {
            return PlanetInformation.GetMass(type);
        }

        public string GetAdditionalInformation(Enum type)
        {
            return PlanetInformation.GetAdditionalInformation(type);
        }
    }
}