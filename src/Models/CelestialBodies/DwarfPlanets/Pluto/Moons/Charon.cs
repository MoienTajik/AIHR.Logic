namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;

public sealed class Charon : SolarSystem.Satellite, IOrbitAround<Pluto>
{
    public override string Name => nameof(Charon);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.586e21;
    
    public double DistanceFromPrimaryBody => 19_570;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(153);
}