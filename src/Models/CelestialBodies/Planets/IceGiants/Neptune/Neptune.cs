using AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Neptune.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Neptune;

public sealed class Neptune : SolarSystem.IceGiant, IHaveSatelliteMoons, IOrbitAround<Sun>
{
    public override string Name => nameof(Neptune);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 2_780_723_919;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(60_190);

    public override double Mass => 1.024e26;

    // Neptune has 14 moons. Skipping other ones for simplicity ...
    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Triton(),
        new Despina()
    };
}