namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Uranus.Moons;

public sealed class Titania : SolarSystem.Satellite, IOrbitAround<Uranus>
{
    public override string Name => nameof(Titania);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 3.400e21;
    
    public double DistanceFromPrimaryBody => 436_000;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(8);
}