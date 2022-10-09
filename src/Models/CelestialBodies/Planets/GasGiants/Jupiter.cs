namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants;

public sealed class Jupiter : SolarSystem.GasGiant, IHasSatelliteMoon
{
    public override string Name => "Jupiter";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 460_532_318;

    public override double OrbitalPeriod => 4_333;

    public override double Mass => 1.898e27;

    // Jupiter has 80 moons. Should we mention all of them?
    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Io"),
        new("Europa"),
        new("Ganymede"),
        new("Callisto")
    };
}