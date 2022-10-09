using AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Jupiter.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.GasGiants.Jupiter;

public sealed class Jupiter : SolarSystem.GasGiant, IHasSatelliteMoon, IOrbitAround<Sun>
{
    public override string Name => nameof(Jupiter);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 460_532_318;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(4_333);

    public override double Mass => 1.898e27;

    // Jupiter has 79 moons. Skipping other ones for simplicity ...
    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Europa(),
        new Io(),
        new Ganymede()
    };
}