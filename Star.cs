using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class Star
    {
        public string Name { get; set; }
        public long Age { get; set; }
        public long Dimension { get; set; }
        public string Mass { get; set; }

        //----------------------------------CONSTRUCTORS
        public Star(string name, long age, long dimension, string mass)
        {
            this.Name = name;
            this.Age = age;
            this.Dimension = dimension;
            this.Mass = mass;
        }
    }
}
