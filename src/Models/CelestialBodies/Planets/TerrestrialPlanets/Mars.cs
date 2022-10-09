namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets;

public sealed class Mars : SolarSystem.TerrestrialPlanet, IHasSatelliteMoon, ICanBeTerraformed
{
    public override string Name => "Mars";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 135_101_879;

    public override double OrbitalPeriod => 687;

    public override double Mass => 6.39e23;

    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Deimos"),
        new("Phobos")
    };
}