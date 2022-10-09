using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Venus;

public sealed class Venus : SolarSystem.TerrestrialPlanet, IOrbitAround<Sun>
{
    public override string Name => nameof(Venus);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 66_946_223;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(225);

    public override double Mass => 4.867e24;
}