namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Mars.Moons;

public sealed class Phobos : SolarSystem.Satellite, IOrbitAround<Mars>
{
    public override string Name => nameof(Phobos);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.0659e16;
    
    public double DistanceFromPrimaryBody => 6_000;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(8);
}