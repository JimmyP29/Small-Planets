using PlanetAPI.Interfaces;
using PlanetAPI.Models;
using System;

namespace PlanetAPI.Helpers
{
    public class PlanetBuilder
    {
        private readonly IPlanetBuilder _planetBuilder;

        public PlanetBuilder(IPlanetBuilder planetBuilder)
        {
            _planetBuilder = planetBuilder;
        }

        public Planet Create(Enum type)
        {
            return _planetBuilder.Create(type);
        }
    }
}