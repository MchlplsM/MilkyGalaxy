using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class Planet
    {
        public string planetName { get; set; }

        public long mesiApostasiApoTonAsteraTou { get; set; }

        public long planetMass { get; set; }

        public int periodosPeriforas { get; set; }

        public int periodosPeristrofis { get; set; } //οι αρνητικές τιμές σημαίνουν απλά αντίστροφη φορά σε σχέση με την περιστροφή της γης

        public bool daxtulioi { get; set; } //YES OR NO

        public bool ghinosPlanitis { get; set; }//YES OR NO

        public bool aerinosPlanitis { get; set; }//YES OR NO

        public bool dwarfPlanet { get; set; }//YES OR NO

        public string atmosphere { get; set; }

        public  List<Satellite> listOfSatellites{ get; set; }

    }
}
