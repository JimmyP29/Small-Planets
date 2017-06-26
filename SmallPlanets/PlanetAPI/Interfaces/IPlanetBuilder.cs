using PlanetAPI.Models;
using System;
using System.Drawing;

namespace PlanetAPI.Interfaces
{
    public interface IPlanetBuilder
    {
        Planet Create(Enum type);
        Bitmap GetImage(Enum type);
        string GetDiameter(Enum type);
        string GetDistanceFromSun(Enum type);
        string GetMass(Enum type);
        string GetAdditionalInformation(Enum type);
    }
}
