using AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Mars.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Mars;

public sealed class Mars : SolarSystem.TerrestrialPlanet, IHaveSatelliteMoons, ICanBeTerraformed, ICanSustainLife, IOrbitAround<Sun>
{
    public override string Name => nameof(Mars);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 135_101_879;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(687);

    public override double Mass => 6.39e23;

    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Phobos(),
        new Deimos()
    };
}