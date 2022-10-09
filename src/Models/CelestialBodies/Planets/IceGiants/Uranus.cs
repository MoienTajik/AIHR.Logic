namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants;

public sealed class Uranus : SolarSystem.IceGiant, IHasSatelliteMoon
{
    public override string Name => "Uranus";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 1_753_240_837;

    public override double OrbitalPeriod => 30_687;

    public override double Mass => 8.681e25;

    // Uranus has 27 moons. Should we mention all of them?
    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Ariel"),
        new("Belinda"),
        new("Caliban"),
        new("Cordelia")
    };
}