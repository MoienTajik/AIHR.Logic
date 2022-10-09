# AIHR.Logic

## How to Run
Navigate to the root of the project and run this command:
```bash
dotnet run --project ./src/AIHR.Logic.csproj
```

## Assumptions
- Since Mars is the only planet that can be terraformed and sustain life (IMO), Colonize is only working on Mars.

## Concerns
- With the current implementation, I used on Reflection to retrieve children of sun to implement **GetCelestialBodiesAroundSun()**. Relying on Reflection in a real-world environment is error-prone and it's better to use a DI Container instead of using Reflection.

- Measurement types for **Mass** and **DistanceFromPrimaryBody** is currently in Kilograms and Kilometers. I used XML summaries for these properties to reflect their measurement type during development, but it's hard to read their value and remember their measurement type. It would be better to use a value-object for each of them using this library [UnitsNet](https://github.com/angularsen/UnitsNet), like using **TimeSpan** for **OrbitalPeriod**.
