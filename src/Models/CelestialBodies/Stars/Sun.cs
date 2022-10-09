namespace AIHR.Logic.Models.CelestialBodies.Stars;

public sealed class Sun : SolarSystem.Star
{
    public override string Name => "Sun";
    
    public override byte[] Picture => Array.Empty<byte>();

    public override double Mass => 1.989e30;
}