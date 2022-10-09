namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Earth.Moons;

public sealed class Moon : SolarSystem.Satellite, IOrbitAround<Earth>
{
    public override string Name => nameof(Moon);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 7.342e22;
    
    public double DistanceFromPrimaryBody => 384_400;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(27);
}