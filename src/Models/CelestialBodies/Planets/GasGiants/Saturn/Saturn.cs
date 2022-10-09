using AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Saturn.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Saturn;

public sealed class Saturn : SolarSystem.GasGiant, IHaveSatelliteMoons, IOrbitAround<Sun>
{
    public override string Name => nameof(Saturn);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 916_269_194;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(10_759);

    public override double Mass => 5.683e26;

    // Saturn has 83 moons. Skipping other ones for simplicity ...
    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Titan(),
        new Enceladus()
    };
}