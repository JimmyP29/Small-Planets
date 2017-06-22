using PlanetAPI.Models;
using System;

namespace PlanetAPI.Interfaces
{
    public interface IPlanetBuilder
    {
        Planet Create(Enum type);
    }
}
