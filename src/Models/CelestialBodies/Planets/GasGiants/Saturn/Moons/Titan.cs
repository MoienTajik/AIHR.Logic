namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Saturn.Moons;

public sealed class Titan : SolarSystem.Satellite, IOrbitAround<Saturn>
{
    public override string Name => nameof(Titan);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.3452e23;
    
    public double DistanceFromPrimaryBody => 1_221_492;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(16);
}