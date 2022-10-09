namespace AIHR.Logic.Models.CelestialBodies;

public abstract class CelestialBody
{
    public abstract string Name { get; }

    public abstract byte[] Picture { get; }

    public abstract double DistanceFromSun { get; }

    public abstract double OrbitalPeriod { get; }

    public abstract double Mass { get; }

    public override string ToString()
    {
        // Using StringBuilder is better to reduce string allocation
        const string separator = "============================================================================================";
        var distanceFromSunKm = $"{DistanceFromSun} KM";
        var orbitalPeriodDays = $"{OrbitalPeriod} Days";
        var massKg = $"{Mass} KG";
        
        return $"{Name.ToUpperInvariant()} => {nameof(DistanceFromSun)}: {distanceFromSunKm}, " +
               $"{nameof(OrbitalPeriod)}: {orbitalPeriodDays}, {nameof(Mass)}: {massKg}" +
               Environment.NewLine +
               separator;
    }
}