namespace AIHR.Logic.Models.CelestialBodies.DwarfPlanets;

public sealed class Pluto : SolarSystem.DwarfPlanet, IHasSatelliteMoon
{
    public override string Name => "Pluto";

    public override byte[] Picture => Array.Empty<byte>();

    public override double DistanceFromSun => 3_218_067_659;

    public override double OrbitalPeriod => 90_530;

    public override double Mass => 1.30900e22;

    public List<IHasSatelliteMoon.Satellite> Satellites => new()
    {
        new("Charon"),
        new("Hydra"),
        new("Kerberos"),
        new("Nix"),
        new("Styx")
    };
}