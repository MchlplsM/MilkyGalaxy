using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class SpaceShip
    {
        public string spaceShipName { get; set; }
        public string captainName { get; set; }
        public int captainAge { get; set; }
        public PlanetSystem systemWhichItTravels { get; set; } //πλανητικό σύστημα δραστηριοποίησης
        public Planet basePlanet { get; set; }
        public Planet targetPlanet { get; set; }
        public double taxutitaTaksidiouInAU { get; set; } //ταχύτητα ταξιδιού( AU )

        //---------------------------------------------CONSTRUCTORS
        public SpaceShip()
        {

        }

        //---------------------------------------------METHODS
        //αναπαριστά το ταξίδι του διαστημοπλοίου από τον πλανήτη βάση στον πλανήτη στόχο με απόσταση μεταξύ τους distance. Για κάθε γήινο έτος που περνάει
        //στο ταξίδι του, εκτυπώνει την πρόταση i + " years passed..", όπου i είναι ο αριθμός των γήινων ετών. Με την άφιξη του στον προορισμό του, εκτυπώνει 
        //την πρόταση " arrived at" + το όνομα του πλανήτη στόχου. Στην συνέχεια θέτει ως νέο πλανήτη βάση τον πλανήτη που έφτασε και θέτει ως πλανήτη στόχο 
        //την τιμή NULL.
        public void Travel(Planet basePlanet, Planet targetPlanet, double distance)
        {
            distance = (double)basePlanet.mesiApostasiApoTonAsteraTou - targetPlanet.mesiApostasiApoTonAsteraTou;
            int i = 0;
            while (distance > 0)
            {
                distance -= taxutitaTaksidiouInAU;
                i++;
                Console.WriteLine($"{i} years passed");
                if (distance <= 0)
                {
                    Console.WriteLine($"The spaceship arrived at {targetPlanet.planetName}");
                    break;
                }
            }
            basePlanet = targetPlanet;
            targetPlanet = null;
            //0,48 light year = 1 earth year
            //1 light year = 63.241 AU
            //1 earth year = 30.355 AU
            //149.597.870.700 metres = 1 Astronomical Unit
            //1 light year = 9.460.730.472.580.800 metres
        }
    }
}
