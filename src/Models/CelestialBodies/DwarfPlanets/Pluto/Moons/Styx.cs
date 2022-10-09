namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;

public sealed class Styx : SolarSystem.Satellite, IOrbitAround<Pluto>
{
    public override string Name => nameof(Styx);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 7.5e15;
    
    public double DistanceFromPrimaryBody => 42_656;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(20);
}