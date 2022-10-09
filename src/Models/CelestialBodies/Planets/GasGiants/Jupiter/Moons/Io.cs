namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Jupiter.Moons;

public sealed class Io : SolarSystem.Satellite, IOrbitAround<Jupiter>
{
    public override string Name => nameof(Io);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 8.931938e22;
    
    public double DistanceFromPrimaryBody => 421_700;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(42);
}