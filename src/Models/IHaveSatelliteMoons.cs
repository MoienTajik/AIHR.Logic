namespace AIHR.Logic.Models;

public interface IHaveSatelliteMoons
{
    public List<SolarSystem.Satellite> Satellites { get; }
}