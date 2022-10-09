namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;

public sealed class Hydra : SolarSystem.Satellite, IOrbitAround<Pluto>
{
    public override string Name => nameof(Hydra);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 4.8e16;
    
    public double DistanceFromPrimaryBody => 64_738;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(38);
}