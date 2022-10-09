namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;

public sealed class Nix : SolarSystem.Satellite, IOrbitAround<Pluto>
{
    public override string Name => nameof(Nix);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 4.5e16;
    
    public double DistanceFromPrimaryBody => 48_700;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(25);
}