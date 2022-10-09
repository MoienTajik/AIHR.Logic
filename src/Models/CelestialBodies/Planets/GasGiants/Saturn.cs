namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants;

public sealed class Saturn : SolarSystem.GasGiant, IHasSatelliteMoon
{
    public override string Name => "Saturn";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 916_269_194;

    public override double OrbitalPeriod => 10_759;

    public override double Mass => 5.683e26;

    // Saturn has 83 moons. Should we mention all of them?
    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Enceladus"),
        new("Titan")
    };
}