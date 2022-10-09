namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Saturn.Moons;

public sealed class Enceladus : SolarSystem.Satellite, IOrbitAround<Saturn>
{
    public override string Name => nameof(Enceladus);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.08022e20;
    
    public double DistanceFromPrimaryBody => 238_000;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(33);
}