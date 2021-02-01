using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class Planet
    {
        public string PlanetName { get; set; } 

        public double MesiApostasiApoTonAsteraTou { get; set; } //Σε AU

        public double PlanetMass { get; set; } //Με βάση τη μάζα της Γης

        public double PeriodosPeriforas { get; set; } //Σε γήινα χρόνια

        public double PeriodosPeristrofis { get; set; } //οι αρνητικές τιμές σημαίνουν απλά αντίστροφη φορά σε σχέση με την περιστροφή της γης

        public bool Daxtulioi { get; set; } //YES OR NO

        public bool GhinosPlanitis { get; set; }//YES OR NO

        public bool AerinosPlanitis { get; set; }//YES OR NO

        public bool DwarfPlanet { get; set; }//YES OR NO

        public string Atmosphere { get; set; }

        public  List<Satellite> ListOfSatellites{ get; set; }

        public Planet(){
            
        }

    }
}
