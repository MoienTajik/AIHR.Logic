namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets;

public sealed class Earth : SolarSystem.TerrestrialPlanet, IHasSatelliteMoon, ICanSustainLife
{
    public override string Name => "Earth";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 92_954_235;

    public override double OrbitalPeriod => 365;

    public override double Mass => 5.972e24;

    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Moon")
    };
}