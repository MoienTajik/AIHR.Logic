namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets;

public sealed class Venus : SolarSystem.TerrestrialPlanet
{
    public override string Name => "Venus";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 66_946_223;

    public override double OrbitalPeriod => 225;

    public override double Mass => 4.867e24;
}