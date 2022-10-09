namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Jupiter.Moons;

public sealed class Ganymede : SolarSystem.Satellite, IOrbitAround<Jupiter>
{
    public override string Name => nameof(Ganymede);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.4819e23;
    
    public double DistanceFromPrimaryBody => 1_070_400;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(172);
}