using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyGalaxy
{
    class Star
    {
        public string name { get; set; }
        public long age { get; set; }
        public long dimension { get; set; }
        public string mass { get; set; }

        //----------------------------------CONSTRUCTORS
        public Star(string name, long age, long dimension, string mass)
        {
            this.name = name;
            this.age = age;
            this.dimension = dimension;
            this.mass = mass;
        }
    }
}
