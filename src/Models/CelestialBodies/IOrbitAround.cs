namespace AIHR.Logic.Models.CelestialBodies;

public interface IOrbitAround
{
    /// <summary>
    /// A primary is the main physical body of a gravitationally bound, multi-object system.
    /// In the Solar System, the Sun is the primary for all objects that orbit the star.
    /// In the same way, the primary of all satellites is the planet they orbit.
    /// <see href="https://en.wikipedia.org/wiki/Primary_body"/>
    /// </summary>
    /// <returns>Distance from primary body in Kilometers.</returns>
    public double DistanceFromPrimaryBody { get; }
    
    public TimeSpan OrbitalPeriod { get; }
}

public interface IOrbitAround<TCelestialBody> : IOrbitAround where TCelestialBody : CelestialBody, new()
{
}