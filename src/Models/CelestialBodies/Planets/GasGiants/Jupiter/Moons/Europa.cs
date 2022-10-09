namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Jupiter.Moons;

public sealed class Europa : SolarSystem.Satellite, IOrbitAround<Jupiter>
{
    public override string Name => nameof(Europa);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 4.799844e22;
    
    public double DistanceFromPrimaryBody => 670_900;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(85);
}