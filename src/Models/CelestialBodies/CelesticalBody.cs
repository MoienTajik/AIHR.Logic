using System.Text;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models.CelestialBodies;

public abstract class CelestialBody
{
    public abstract string Name { get; }

    public abstract byte[] Picture { get; }

    /// <summary>
    /// Mass in Kilograms.
    /// </summary>
    public abstract double Mass { get; }

    public override string ToString()
    {
        const string separator = "============================================================================================";

        var sb = new StringBuilder();
        if (this is IOrbitAround orbitingBody)
        {
            var primaryBody = orbitingBody
                .GetType()
                .FindInterfaces((type, _) => type.IsGenericType, null)
                .First().GenericTypeArguments[0].Name;
            
            var distanceFromPrimaryBody = $"{orbitingBody.DistanceFromPrimaryBody} KM";
            var orbitalPeriodDays = $"{orbitingBody.OrbitalPeriod.TotalDays} Days and {orbitingBody.OrbitalPeriod.Hours} Hours";
            sb.Append($"{Name.ToUpperInvariant()} => Distance from {primaryBody.ToUpperInvariant()}: {distanceFromPrimaryBody}, ");
            sb.Append($"Orbits around {primaryBody} every: {orbitalPeriodDays}, {nameof(Mass)}: {Mass} KG");
            
            if (this is IHasSatelliteMoon bodyWithSatellite)
            {
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine("SATELLITE MOONS:");
                bodyWithSatellite.Satellites.ForEach(satellite => sb.AppendLine(satellite.ToString()));
            }
            
            if(this is IOrbitAround<Sun>)
            {
                sb.AppendLine();
                sb.AppendLine(separator);
            }
        }
        
        return sb.ToString();
    }
}