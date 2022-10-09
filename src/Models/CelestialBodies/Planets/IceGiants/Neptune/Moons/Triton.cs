namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Neptune.Moons;

public sealed class Triton : SolarSystem.Satellite, IOrbitAround<Neptune>
{
    public override string Name => nameof(Triton);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 2.1390e22;
    
    public double DistanceFromPrimaryBody => 354_800;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(141);
}