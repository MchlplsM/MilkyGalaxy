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
        public bool daxtulioi { get; set; }
        public bool ghinosPlanitis { get; set; }
        public bool aerinosPlanitis { get; set; }
        public bool dwarfPlanet { get; set; }
        public string atmosphere { get; set; }
        public  List<Satellite> listOfSatellites{ get; set; }

    }
}
