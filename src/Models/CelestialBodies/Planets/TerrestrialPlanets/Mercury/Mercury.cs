using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.TerrestrialPlanets.Mercury;

public sealed class Mercury : SolarSystem.TerrestrialPlanet, IOrbitAround<Sun>
{
    public override string Name => nameof(Mercury);
    
    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 3.285e23;

    public double DistanceFromPrimaryBody => 28_613_231;
    
    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(88);
}