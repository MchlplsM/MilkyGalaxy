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
            //Υλοποιήστε το ηλιακό μας πλανητικό σύστημα με έναν αστέρα -τον ήλιο, τους 8 πλανήτες του (+1 τον Πλούτωνα) και τους δορυφόρους σε κάθε ένα από αυτούς 

            //Creating the Planet System
            PlanetSystem planetSystem = new PlanetSystem();

            //Creating the Star SUN & adding the Sun to the PlanetSystem
            Star Sun = new Star("Sun", 4600000000, 696000, (19885 * (Math.Pow(10, 30))).ToString());
            planetSystem.asterasTouSustimatos = Sun;

            //Text file
            string planetTxtFile = @"Planets.txt"; //could use -@- if i inserted full path or -\-
            string doruforoiTxtFile = @"Doruforoi.txt";
            string aktinaDoruforouTxtFile = @"AktinaTouDoruforou.txt";
            string PeriodosPeristrofisDoruforouTxtFile = @"PeriodosPeristrofisDoruforou.txt";

            AddPlanetsTothePlanetSystemAndAddSatellitesToEachPlanet(planetSystem, planetTxtFile, doruforoiTxtFile, aktinaDoruforouTxtFile, PeriodosPeristrofisDoruforouTxtFile);

            //Eκτυπώστε την συνολική μάζα των πλανητών του ηλιακού μας σύστήματος που έχουν περισσότερους από τρεις δορυφόρους
            TotalMassOfPlanetsWhoHaveMoreThanThreeSatellites(planetSystem);

            //εκτυπώστε τα ονόματα των πλανητών που είναι αέρινοι, έχουν δακτύλιο και οι ακτίνα των δορυφόρων τους είναι μεγαλύτερη ή ίση της ακτίνας του δορυφόρου με το όνομα ΠΟΛΥΔΕΥΚΗΣ 
            //και μικρότερη ή ίση της ακτίνας του δορυφόρου ΤΙΤΑΝΙΑ.Επιπλέον για κάθε έναν από αυτούς, εκτυπώστε το πλήθος και τα ονόματα των δορυφόρων τους.
            PrintAllPlanetsWhoAreAerialHaveARingAndTheRadiusOfTheirSatellitesIsBiggerOrEqualToSatellitePolydeucesAndSmallerOrEqualToSatelliteTitania(planetSystem);


            //εκτυπώστε τα ονόματα των δορυφόρων εκείνων των πλανητών που η περίοδος περιφοράς τους γύρω από τον ήλιο είναι μεγαλύτερη της περιόδου περιφοράς γύρω από τον ήλιο της 
            //ΑΦΡΟΔΙΤΗΣ και μικρότερη του ΟΥΡΑΝΟΥ και το σύνολο των δορυφόρων τους που έχουν περίοδο περιστροφής γύρω από τον άξονα τους μεγαλύτερο της ΜΝΗΜΗΣ, είναι μεγαλύτερο του 3
            PrintSatellitesOfPlanetsWithOrbitalPeriodBiggerThanAfroditiAndSmallerThanOuranouAndTheSatellitesHaveAnOrbitalPeriodBiggerThanMneme(planetSystem);
        }

        private static void PrintAllPlanetsWhoAreAerialHaveARingAndTheRadiusOfTheirSatellitesIsBiggerOrEqualToSatellitePolydeucesAndSmallerOrEqualToSatelliteTitania(PlanetSystem planetSystem)
        {
            Satellite Polydeuces = planetSystem.getSatellite("Polydeuces");
            Satellite Titania = planetSystem.getSatellite("Titania");
            for (int i = 0; i < planetSystem.listOfPlanets.Count; i++)
            {
                if (planetSystem.listOfPlanets[i].Daxtulioi == true && planetSystem.listOfPlanets[i].AerinosPlanitis == true)
                {
                    int counter = 0;
                    for (int k = 0; k < planetSystem.listOfPlanets[i].ListOfSatellites.Count; k++)
                    {
                        if ((planetSystem.listOfPlanets[i].ListOfSatellites[k].AktinaTouDoruforou < Polydeuces.AktinaTouDoruforou) && planetSystem.listOfPlanets[i].ListOfSatellites[k].AktinaTouDoruforou > Titania.AktinaTouDoruforou)
                        {
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine($"\nThe planet {planetSystem.listOfPlanets[i].PlanetName} is aerial, has a ring and all the satellites of that particular planet have a radius >= to Polydeuces" +
                            $" and also have a radius <= to Titania. The total number of satellites of planet {planetSystem.listOfPlanets[i].PlanetName} is: {planetSystem.listOfPlanets[i].ListOfSatellites.Count}");
                        Console.WriteLine($"Please find below their respective names:");
                        for (int k = 0; k < planetSystem.listOfPlanets[i].ListOfSatellites.Count; k++)
                        {
                            Console.WriteLine($"{k + 1} - {planetSystem.listOfPlanets[i].ListOfSatellites[k].SatelliteName}");
                        }
                    }
                }
            }
        }

        private static void PrintSatellitesOfPlanetsWithOrbitalPeriodBiggerThanAfroditiAndSmallerThanOuranouAndTheSatellitesHaveAnOrbitalPeriodBiggerThanMneme(PlanetSystem planetSystem)
        {
            Satellite Mneme = planetSystem.getSatellite("Mneme");
            for (int i = 0; i < planetSystem.listOfPlanets.Count; i++)
            {
                int counter = 0;
                List<Satellite> satellitesMePeriodoPeriforaMegaluteriTisMneme = new List<Satellite>();
                if (planetSystem.listOfPlanets[i].PlanetName != "Afroditi" && planetSystem.listOfPlanets[i].PlanetName != "Ouranos")
                {
                    if (planetSystem.listOfPlanets[i].PeriodosPeriforas > planetSystem.listOfPlanets[1].PeriodosPeriforas && planetSystem.listOfPlanets[i].PeriodosPeriforas < planetSystem.listOfPlanets[6].PeriodosPeriforas)
                    {
                        for (int k = 0; k < planetSystem.listOfPlanets[i].ListOfSatellites.Count; k++)
                        {
                            if (planetSystem.listOfPlanets[i].ListOfSatellites[k].PeriodosPeristrofis > Mneme.PeriodosPeristrofis)
                            {
                                counter++;
                                satellitesMePeriodoPeriforaMegaluteriTisMneme.Add(planetSystem.listOfPlanets[i].ListOfSatellites[k]);
                            }
                        }
                        if (counter > 3)
                        {
                            Console.WriteLine($"Planet {planetSystem.listOfPlanets[i].PlanetName} has more than 3 satellites that fullfil the criteria:");
                            for (int c = 0; c < satellitesMePeriodoPeriforaMegaluteriTisMneme.Count; c++)
                            {
                                Console.WriteLine($"{satellitesMePeriodoPeriforaMegaluteriTisMneme[c].SatelliteName} has an orbital period of: {satellitesMePeriodoPeriforaMegaluteriTisMneme[c].PeriodosPeristrofis}");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        private static void TotalMassOfPlanetsWhoHaveMoreThanThreeSatellites(PlanetSystem planetSystem)
        {
            Console.WriteLine("Print the total mass of the planets of our planet system who have more than 3 satellites");
            double totalMassOfPlanetsWhoHaveMoreThan3Satellites = 0;
            for (int i = 0; i < planetSystem.listOfPlanets.Count; i++)
            {
                if (planetSystem.listOfPlanets[i].ListOfSatellites.Count > 3)
                {
                    totalMassOfPlanetsWhoHaveMoreThan3Satellites += planetSystem.listOfPlanets[i].PlanetMass;
                    Console.WriteLine($"{planetSystem.listOfPlanets[i].PlanetName} - Planet's Mass = {planetSystem.listOfPlanets[i].PlanetMass} X 10^+-25kg - Planet's Satellites in No = {planetSystem.listOfPlanets[i].ListOfSatellites.Count}");
                }
            }
            Console.WriteLine($"The total mass of the aformentioned planets is: {totalMassOfPlanetsWhoHaveMoreThan3Satellites} X 10^+-25kg");
            Console.WriteLine();
        }

        private static void AddPlanetsTothePlanetSystemAndAddSatellitesToEachPlanet(PlanetSystem planetSystem, string planetTxtFile, string doruforoiTxtFile, string aktinaDoruforouTxtFile, string PeriodosPeristrofisDoruforouTxtFile)
        {
            if (File.Exists(planetTxtFile) && File.Exists(doruforoiTxtFile))
            {
                string[] planetLines = File.ReadAllLines(planetTxtFile);
                string[] doruforoiLines = File.ReadAllLines(doruforoiTxtFile);
                string[] aktinaDoruforouLines = File.ReadAllLines(aktinaDoruforouTxtFile);
                string[] periodosPeristrofisDoruforouLines = File.ReadAllLines(PeriodosPeristrofisDoruforouTxtFile);
                int j = 0;
                for (int i = 0; i < 90; i++)
                {
                    Planet RandomPlanet = new Planet
                    {
                        PlanetName = planetLines[i],
                        MesiApostasiApoTonAsteraTou = Convert.ToDouble(planetLines[i + 1]),
                        PlanetMass = Convert.ToDouble(planetLines[i + 2]),
                        PeriodosPeriforas = Convert.ToDouble(planetLines[i + 3]),
                        PeriodosPeristrofis = Convert.ToDouble(planetLines[i + 4]),
                        Daxtulioi = Convert.ToBoolean(planetLines[i + 5]),
                        GhinosPlanitis = Convert.ToBoolean(planetLines[i + 6]),
                        AerinosPlanitis = Convert.ToBoolean(planetLines[i + 7]),
                        DwarfPlanet = Convert.ToBoolean(planetLines[i + 8]),
                        Atmosphere = planetLines[i + 9],
                        ListOfSatellites = new List<Satellite>()
                    };
                    i += 9;
                    if (RandomPlanet.PlanetName != "Ermis" && RandomPlanet.PlanetName != "Afroditi")
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
                                satellite.SatelliteName = doruforoiLines[j];
                                satellite.AktinaTouDoruforou = Convert.ToDouble(aktinaDoruforouLines[j]);
                                satellite.PeriodosPeristrofis = Convert.ToDouble(periodosPeristrofisDoruforouLines[j]);
                                RandomPlanet.ListOfSatellites.Add(satellite);
                                j++;
                            }
                        }
                    }
                    PrintThePlanetAndAllItsDetails(RandomPlanet);
                    planetSystem.listOfPlanets.Add(RandomPlanet);
                }
            }
        }

        private static void PrintThePlanetAndAllItsDetails(Planet RandomPlanet)
        {
            Console.WriteLine($"{RandomPlanet.PlanetName} has {RandomPlanet.MesiApostasiApoTonAsteraTou}AU distance from Sun. The {RandomPlanet.PlanetName}'s mass " +
                                    $"is X {RandomPlanet.PlanetMass} compared to Earth's. It takes {RandomPlanet.PeriodosPeriforas} earth years for the planet to complete a full rotation " +
                                    $"around the Sun. It takes {RandomPlanet.PeriodosPeristrofis} days for the planet to rotate around itself. The atmosphere mainly consists of: {RandomPlanet.Atmosphere}");
            if (RandomPlanet.Daxtulioi)
                Console.WriteLine($"{RandomPlanet.PlanetName} does have a ring/-s");
            else
                Console.WriteLine($"{RandomPlanet.PlanetName} does NOT have a ring/-s");
            if (RandomPlanet.GhinosPlanitis)
                Console.WriteLine($"{RandomPlanet.PlanetName} is an earth planet");
            else
                Console.WriteLine($"{RandomPlanet.PlanetName} is not an earth planet");
            if (RandomPlanet.DwarfPlanet)
                Console.WriteLine($"{RandomPlanet.PlanetName} is a dwarf planet");
            else
                Console.WriteLine($"{RandomPlanet.PlanetName} is not a dwarf planet");
            if (RandomPlanet.ListOfSatellites.Count > 0)
            {
                Console.WriteLine($"The planet {RandomPlanet.PlanetName} has the following satellites:");
                for (int k = 0; k < RandomPlanet.ListOfSatellites.Count; k++)
                {
                    Console.WriteLine($"{RandomPlanet.ListOfSatellites[k].SatelliteName} - Radius = {RandomPlanet.ListOfSatellites[k].AktinaTouDoruforou}km - Sidereal Period = {RandomPlanet.ListOfSatellites[k].PeriodosPeristrofis}");
                }
            }
            Console.WriteLine("");
        }
    }
}
