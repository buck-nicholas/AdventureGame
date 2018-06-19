using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class NPC
    {
        // Member Variables
        public string name;
        public bool aggro;
        public double health;

        // constructor
        public NPC(string name, bool aggro, double health)
        {
            this.name = name;
            this.aggro = aggro;
            this.health = health;
        }
        // methods
        public void WriteMessage(string message)
        {
            Console.WriteLine(name + ": " + message);
        }
    }
}
