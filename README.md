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

<hr/>

#### Sample output
```
MERCURY => Distance from SUN: 28613231 KM, Orbits around Sun every: 88 Days and 0 Hours, Mass: 3.285E+23 KG
============================================================================================
VENUS => Distance from SUN: 66946223 KM, Orbits around Sun every: 225 Days and 0 Hours, Mass: 4.867E+24 KG
============================================================================================

EARTH => Distance from SUN: 92954235 KM, Orbits around Sun every: 365 Days and 0 Hours, Mass: 5.972E+24 KG

SATELLITE MOONS:
MOON => Distance from EARTH: 384400 KM, Orbits around Earth every: 27 Days and 0 Hours, Mass: 7.342E+22 KG

============================================================================================

Mars CAN BE COLONIZED
MARS => Distance from SUN: 135101879 KM, Orbits around Sun every: 687 Days and 0 Hours, Mass: 6.39E+23 KG

SATELLITE MOONS:
PHOBOS => Distance from MARS: 6000 KM, Orbits around Mars every: 0.3333333333333333 Days and 8 Hours, Mass: 10659000000000000 KG
DEIMOS => Distance from MARS: 23460 KM, Orbits around Mars every: 1.25 Days and 6 Hours, Mass: 1476200000000000 KG

============================================================================================
CERES => Distance from SUN: 237585646 KM, Orbits around Sun every: 1680 Days and 0 Hours, Mass: 9.1E+20 KG
============================================================================================

JUPITER => Distance from SUN: 460532318 KM, Orbits around Sun every: 4333 Days and 0 Hours, Mass: 1.898E+27 KG

SATELLITE MOONS:
EUROPA => Distance from JUPITER: 670900 KM, Orbits around Jupiter every: 3.5416666666666665 Days and 13 Hours, Mass: 4.799844E+22 KG
IO => Distance from JUPITER: 421700 KM, Orbits around Jupiter every: 1.75 Days and 18 Hours, Mass: 8.931938E+22 KG
GANYMEDE => Distance from JUPITER: 1070400 KM, Orbits around Jupiter every: 7.166666666666667 Days and 4 Hours, Mass: 1.4819E+23 KG

============================================================================================

SATURN => Distance from SUN: 916269194 KM, Orbits around Sun every: 10759 Days and 0 Hours, Mass: 5.683E+26 KG

SATELLITE MOONS:
TITAN => Distance from SATURN: 1221492 KM, Orbits around Saturn every: 16 Days and 0 Hours, Mass: 1.3452E+23 KG
ENCELADUS => Distance from SATURN: 238000 KM, Orbits around Saturn every: 1.375 Days and 9 Hours, Mass: 1.08022E+20 KG

============================================================================================

URANUS => Distance from SUN: 1753240837 KM, Orbits around Sun every: 30687 Days and 0 Hours, Mass: 8.681E+25 KG

SATELLITE MOONS:
TITANIA => Distance from URANUS: 436000 KM, Orbits around Uranus every: 8 Days and 0 Hours, Mass: 3.4E+21 KG
MIRANDA => Distance from URANUS: 129800 KM, Orbits around Uranus every: 1.4166666666666667 Days and 10 Hours, Mass: 6.4E+19 KG

============================================================================================

NEPTUNE => Distance from SUN: 2780723919 KM, Orbits around Sun every: 60190 Days and 0 Hours, Mass: 1.024E+26 KG

SATELLITE MOONS:
TRITON => Distance from NEPTUNE: 354800 KM, Orbits around Neptune every: 5.875 Days and 21 Hours, Mass: 2.139E+22 KG
DESPINA => Distance from NEPTUNE: 27700 KM, Orbits around Neptune every: 0.3333333333333333 Days and 8 Hours, Mass: 2.2E+18 KG

============================================================================================

PLUTO => Distance from SUN: 3218067659 KM, Orbits around Sun every: 90530 Days and 0 Hours, Mass: 1.309E+22 KG

SATELLITE MOONS:
CHARON => Distance from PLUTO: 19570 KM, Orbits around Pluto every: 153 Days and 0 Hours, Mass: 1.586E+21 KG
NIX => Distance from PLUTO: 48700 KM, Orbits around Pluto every: 25 Days and 0 Hours, Mass: 45000000000000000 KG
STYX => Distance from PLUTO: 42656 KM, Orbits around Pluto every: 20 Days and 0 Hours, Mass: 7500000000000000 KG
KERBEROS => Distance from PLUTO: 57783 KM, Orbits around Pluto every: 32 Days and 0 Hours, Mass: 16500000000000000 KG
HYDRA => Distance from PLUTO: 64738 KM, Orbits around Pluto every: 38 Days and 0 Hours, Mass: 48000000000000000 KG

============================================================================================
```
