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

            //ALL TEXT FILES
            string planetTxtFile = @"Planets.txt"; //could use -@- if i inserted full path or -\-
            string mesiApostasiApoTonAsteraTouTxtFile = @"MesiApostasiApoTonAsteraTou.txt";
            string planetMassTxtFile = @"PlanetMass.txt";
            string periodosPeriforasTxtFile = @"PeriodosPeriforas.txt";


            if (File.Exists(planetTxtFile) /*&& File.Exists(mesiApostasiApoTonAsteraTouTxtFile)*/)
            {
                string[] planetLines = File.ReadAllLines(planetTxtFile);
                string[] mesiApostasiApoTonAsteraTouLines = File.ReadAllLines(mesiApostasiApoTonAsteraTouTxtFile);
                string[] planetMassLines = File.ReadAllLines(planetMassTxtFile);
                string[] periodosPeriforasLines = File.ReadAllLines(periodosPeriforasTxtFile);
                for (int i = 0; i < 9; i++)
                {
                    Planet RandomPlanet = new Planet();
                    RandomPlanet.planetName = planetLines[i];
                    RandomPlanet.mesiApostasiApoTonAsteraTou = Convert.ToDouble(mesiApostasiApoTonAsteraTouLines[i]);
                    RandomPlanet.planetMass = Convert.ToDouble(planetMassLines[i]);
                    RandomPlanet.periodosPeriforas = Convert.ToDouble(periodosPeriforasLines[i]);
                    Console.WriteLine($"{RandomPlanet.planetName} has {RandomPlanet.mesiApostasiApoTonAsteraTou}AU distance from Sun. The {RandomPlanet.planetName}'s mass " +
                        $"is X {RandomPlanet.planetMass} compared to Earth's. It takes {RandomPlanet.periodosPeriforas} earth years for the planet to complete a full rotation " +
                        $"around the Sun\n");
                    
                    planetSystem.listOfPlanets.Add(RandomPlanet);
                }
            }

        }
    }
}
