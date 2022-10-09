namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Mars.Moons;

public sealed class Deimos : SolarSystem.Satellite, IOrbitAround<Mars>
{
    public override string Name => nameof(Deimos);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.4762e15;
    
    public double DistanceFromPrimaryBody => 23_460;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromHours(30);
}