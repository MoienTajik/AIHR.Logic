namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets;

public sealed class Mercury : SolarSystem.TerrestrialPlanet
{
    public override string Name => "Mercury";
    
    public override byte[] Picture => Array.Empty<byte>();
    
    public override double DistanceFromSun => 28_613_231;
    
    public override double OrbitalPeriod => 88;
    
    public override double Mass => 3.285e23;
}