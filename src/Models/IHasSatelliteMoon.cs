namespace AIHR.Logic.Models;

public interface IHasSatelliteMoon
{
    public List<Satellite> Satellites { get; }
    
    public record Satellite(string Name);
}