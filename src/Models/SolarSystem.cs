using AIHR.Logic.Models.CelestialBodies;
using AIHR.Logic.Models.CelestialBodies.Stars;

namespace AIHR.Logic.Models;

public abstract class SolarSystem
{
    public static List<CelestialBody> GetCelestialBodiesAroundSun()
    {
        return typeof(Sun).Assembly
            .GetTypes()
            .Where(type => type.IsClass &&
                           !type.IsAbstract &&
                           type.IsAssignableTo(typeof(IOrbitAround<Sun>)))
            .Select(type => (IOrbitAround<Sun>)Activator.CreateInstance(type)!)
            .OrderBy(celestialBody => celestialBody.OrbitalPeriod)
            .Cast<CelestialBody>()
            .ToList();
    }

    #region Celestial Body Types

    public abstract class Star : CelestialBody
    {
    }
    
    public abstract class Planet : CelestialBody
    {
    }

    public abstract class DwarfPlanet : CelestialBody
    {
    }

    public abstract class Satellite : CelestialBody
    {
    }

    #endregion

    
    #region Planet Types

    public abstract class TerrestrialPlanet : Planet
    {
    }
    
    public abstract class GasGiant : Planet
    {
    }
    
    public abstract class IceGiant : Planet
    {
    }

    #endregion
}