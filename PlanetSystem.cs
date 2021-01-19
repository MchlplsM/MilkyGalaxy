﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class PlanetSystem
    {
        public Star asterasTouSustimatos { get; set; }
        public List<Planet> listOfPlanets = new List<Planet>();


        public Planet GetPlanet(string planetName)
        {
            int position = 0;
            for (int i = 0; i < listOfPlanets.Count; i++)
            {
                if (listOfPlanets[i].planetName == planetName)
                {
                    position = i;
                    break;
                }
            }
            return listOfPlanets[position];
        }

        public Satellite getSatellite(string satelliteName)
        {
            int planetPosition = 0, satellitePosition = 0;
            for (int i = 0; i < listOfPlanets.Count; i++)
            {
                for (int j = 0; j < listOfPlanets[i].listOfSatellites.Count; j++)
                {
                    if (listOfPlanets[i].listOfSatellites[j].satelliteName == satelliteName)
                    {
                        planetPosition = i;
                        satellitePosition = j;
                        break;
                    }
                }
            }
            return listOfPlanets[planetPosition].listOfSatellites[satellitePosition];
        }

        public void PrintThePlanetSystem(Star name)
        {

            
        }
    }
}


//2) μέθοδο Satellite getSatellite(string) που παραλαμβάνει ένα string και επιστρέφει έναν δορυφόρο που 
//    έχει όνομα ίδιο με το string της παραμέτρου και ανήκει σε έναν από τους πλανήτες στην λίστα πλανητών του συστήματος.  