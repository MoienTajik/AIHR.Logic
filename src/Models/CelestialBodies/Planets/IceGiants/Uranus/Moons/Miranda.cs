namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Uranus.Moons;

public sealed class Miranda : SolarSystem.Satellite, IOrbitAround<Uranus>
{
    public override string Name => nameof(Miranda);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 6.4e19;
    
    public double DistanceFromPrimaryBody => 129_800;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(34);
}