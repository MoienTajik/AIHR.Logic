using AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Uranus.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.Planets.IceGiants.Uranus;

public sealed class Uranus : SolarSystem.IceGiant, IHaveSatelliteMoons, IOrbitAround<Sun>
{
    public override string Name => nameof(Uranus);

    public override byte[] Picture => Array.Empty<byte>();

    public double DistanceFromPrimaryBody => 1_753_240_837;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(30_687);

    public override double Mass => 8.681e25;

    // Uranus has 27 moons. Skipping other ones for simplicity ...
    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Titania(),
        new Miranda()
    };
}