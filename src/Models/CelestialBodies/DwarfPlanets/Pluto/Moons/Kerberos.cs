namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;

public sealed class Kerberos : SolarSystem.Satellite, IOrbitAround<Pluto>
{
    public override string Name => nameof(Kerberos);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.65e16;
    
    public double DistanceFromPrimaryBody => 57_783;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(32);
}