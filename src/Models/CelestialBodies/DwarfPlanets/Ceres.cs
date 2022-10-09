namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets;

public sealed class Ceres : SolarSystem.DwarfPlanet
{
    public override string Name => "Ceres";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 237_585_646;

    public override double OrbitalPeriod => 1_680;

    public override double Mass => 9.1e20;
}