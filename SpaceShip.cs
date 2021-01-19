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
        public PlanetSystem systemWhichItTravels { get; set; }
        public Planet basePlanet { get; set; }
        public Planet targetPlanet { get; set; }
        public double speedAU { get; set; }

        public void Travel(Planet basePlanet, Planet targetPlanet, double distance)
        {
            while (distance > 0)
            {

            }
            //From Mercury To Venus  AU 0.34   KM 50,290,000 
            //η οποία
            //αναπαριστά το ταξίδι του διαστημοπλοίου από τον πλανήτη βάση στον πλανήτη στόχο με απόσταση μεταξύ τους distance. Για κάθε γήινο έτος που περνάει
            //στο ταξίδι του, εκτυπώνει την πρόταση i + " years passed..", όπου i είναι ο αριθμός των γήινων ετών. Με την άφιξη του στον προορισμό του, εκτυπώνει 
            //την πρόταση " arrived at" + το όνομα του πλανήτη στόχου. Στην συνέχεια θέτει ως νέο πλανήτη βάση τον πλανήτη που έφτασε και θέτει ως πλανήτη στόχο 
            //την τιμή NULL.

            //13 light years = 27 earth years
            //0,48 light year = 1 earth year

            //149.597.870.700 metres = 1 Astronomical Unit
            //1 light year = 9.460.730.472.580.800 metres
        }
    }
}
