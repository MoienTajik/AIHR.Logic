using AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto.Moons;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets.Pluto;

public sealed class Pluto : SolarSystem.DwarfPlanet, IHaveSatelliteMoons, IOrbitAround<Sun>
{
    public override string Name => nameof(Pluto);

    public override byte[] Picture => Array.Empty<byte>();
    
    public override double Mass => 1.30900e22;

    public double DistanceFromPrimaryBody => 3_218_067_659;

    public TimeSpan OrbitalPeriod => TimeSpan.FromDays(90_530);

    public List<SolarSystem.Satellite> Satellites => new()
    {
        new Charon(),
        new Nix(),
        new Styx(),
        new Kerberos(),
        new Hydra()
    };
}