namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants;

public sealed class Neptune : SolarSystem.IceGiant, IHasSatelliteMoon
{
    public override string Name => "Neptune";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 2_780_723_919;

    public override double OrbitalPeriod => 60_190;

    public override double Mass => 1.024e26;

    // Neptune has 14 moons. Should we mention all of them?
    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Despina"),
        new("Galatea"),
        new("Halimede"),
        new("Hippocamp")
    };
}