namespace AIHR.Logic.Models;

public interface IHasSatelliteMoon
{
    public List<SolarSystem.Satellite> Satellites { get; }
}