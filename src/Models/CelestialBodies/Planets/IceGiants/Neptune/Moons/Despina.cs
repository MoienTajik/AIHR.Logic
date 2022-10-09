namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Neptune.Moons;

public sealed class Despina : SolarSystem.Satellite, IOrbitAround<Neptune>
{
    public override string Name => nameof(Despina);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 2.2e18;
    
    public double DistanceFromPrimaryBody => 27_700;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(8);
}