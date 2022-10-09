using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Ceres;

public sealed class Ceres : SolarSystem.DwarfPlanet, IOrbitAround<Sun>
{
    public override string Name => nameof(Ceres);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 237_585_646;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(1_680);

    public override double Mass => 9.1e20;
}