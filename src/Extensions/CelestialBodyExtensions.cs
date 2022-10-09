using AIHR.Logic.Models;
using AIHR.Logic.Models.CelestialBodies;

namespace AIHR.Logic.Extensions;

public static class CelestialBodyExtensions
{
    public static void Colonize(this CelestialBody celestialBody)
    {
        if (celestialBody is ICanBeTerraformed and ICanSustainLife)
        {
            Console.WriteLine($"COLONIZING {celestialBody.Name} ...");
        }
    }
}