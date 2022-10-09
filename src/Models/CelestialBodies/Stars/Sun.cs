namespace AIHR.Logic.Models.CelestialBodies.Stars;

public sealed class Sun : SolarSystem.Star
{
    public override string Name => "Sun";
    
    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 0;
    
    public override double OrbitalPeriod => 82_546_500_000;
    
    public override double Mass => 1.989e30;
}