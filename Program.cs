using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the Planet System
            PlanetSystem planetSystem = new PlanetSystem();

            //Creating the Star SUN & adding the Sun to the PlanetSystem
            Star Sun = new Star("Sun", 4600000000, 696000, (19885*(Math.Pow(10, 30))).ToString());
            planetSystem.asterasTouSustimatos = Sun;

            //Text file
            string planetTxtFile = @"Planets.txt"; //could use -@- if i inserted full path or -\-
            string doruforoiTxtFile = @"Doruforoi.txt";
            
            if (File.Exists(planetTxtFile) /*&& File.Exists(mesiApostasiApoTonAsteraTouTxtFile)*/)
            {
                string[] planetLines = File.ReadAllLines(planetTxtFile);
                string[] doruforoiLines = File.ReadAllLines(doruforoiTxtFile);
                int j = 0;
                for (int i = 0; i < 90; i++)
                {
                    Planet RandomPlanet = new Planet
                    {
                        planetName = planetLines[i],
                        mesiApostasiApoTonAsteraTou = Convert.ToDouble(planetLines[i + 1]),
                        planetMass = Convert.ToDouble(planetLines[i + 2]),
                        periodosPeriforas = Convert.ToDouble(planetLines[i + 3]),
                        periodosPeristrofis = Convert.ToDouble(planetLines[i + 4]),
                        daxtulioi = Convert.ToBoolean(planetLines[i + 5]),
                        ghinosPlanitis = Convert.ToBoolean(planetLines[i + 6]),
                        aerinosPlanitis = Convert.ToBoolean(planetLines[i + 7]),
                        dwarfPlanet = Convert.ToBoolean(planetLines[i + 8]),
                        atmosphere = planetLines[i + 9],
                        listOfSatellites = new List<Satellite>()
                    };
                    i += 9;
                    if (RandomPlanet.planetName != "Ermis" && RandomPlanet.planetName != "Afroditi")
                    {
                        for (; ; )
                        {
                            if (doruforoiLines[j] == "")
                            {
                                j++;
                                break;
                            }
                            else
                            {
                                Satellite satellite = new Satellite();
                                satellite.satelliteName = doruforoiLines[j];
                                RandomPlanet.listOfSatellites.Add(satellite);
                                j++;
                            }
                        }
                    }
                    Console.WriteLine($"{RandomPlanet.planetName} has {RandomPlanet.mesiApostasiApoTonAsteraTou}AU distance from Sun. The {RandomPlanet.planetName}'s mass " +
                        $"is X {RandomPlanet.planetMass} compared to Earth's. It takes {RandomPlanet.periodosPeriforas} earth years for the planet to complete a full rotation " +
                        $"around the Sun. It takes {RandomPlanet.periodosPeristrofis} days for the planet to rotate around itself. The atmosphere mainly consists of: {RandomPlanet.atmosphere}");
                    if (RandomPlanet.daxtulioi)
                        Console.WriteLine($"{RandomPlanet.planetName} does have a ring/-s");
                    else
                        Console.WriteLine($"{RandomPlanet.planetName} does NOT have a ring/-s");
                    if (RandomPlanet.ghinosPlanitis)
                        Console.WriteLine($"{RandomPlanet.planetName} is an earth planet");
                    else
                        Console.WriteLine($"{RandomPlanet.planetName} is not an earth planet");
                    if (RandomPlanet.dwarfPlanet)
                        Console.WriteLine($"{RandomPlanet.planetName} is a dwarf planet");
                    else
                        Console.WriteLine($"{RandomPlanet.planetName} is not a dwarf planet");
                    Console.WriteLine($"The planet {RandomPlanet.planetName} has the following satellites:");
                    
                    if (RandomPlanet.planetName != "Ermis" && RandomPlanet.planetName != "Afroditi")
                    {
                        for (int k = 0; k < RandomPlanet.listOfSatellites.Count; k++)
                        {
                            Console.WriteLine($"{RandomPlanet.listOfSatellites[k].satelliteName}");
                        }
                    }
                    Console.WriteLine("");
                    planetSystem.listOfPlanets.Add(RandomPlanet);
                }
            }

        }
    }
}
