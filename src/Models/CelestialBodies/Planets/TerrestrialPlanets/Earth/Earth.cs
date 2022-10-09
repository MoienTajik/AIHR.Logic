using AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Earth.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Earth;

public sealed class Earth : SolarSystem.TerrestrialPlanet, IHasSatelliteMoon, ICanSustainLife, IOrbitAround<Sun>
{
    public override string Name => nameof(Earth);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 92_954_235;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(365);

    public override double Mass => 5.972e24;

    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Moon()
    };
}