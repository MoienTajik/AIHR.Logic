using AIHR.Logic.Extensions;
using AIHR.Logic.Models;

var celestialBodiesAroundSun = SolarSystem.GetCelestialBodiesAroundSun();
celestialBodiesAroundSun.ForEach(celestialBody =>
{
    if (celestialBody is ICanBeTerraformed)
    {
        celestialBody.Colonize();
    }

    Console.WriteLine(celestialBody);
});

Console.ReadKey();