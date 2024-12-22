using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    internal class Player
    {
        public String name;
        public int health = 50;
        public int energy = 20;
        public int weaponValue = 10;
        public int amuletValue = 0;
        public int potionCount = 0;

        public void resetAttributes()
        {
            Program.player1.health = 50;
            Program.player1.energy = 20;
            Program.player1.weaponValue = 10;
            Program.player1.amuletValue = 0;
            Program.player1.potionCount = 0;
        }

        public void resetHNE()
        {
            Program.player1.health = 50;
            Program.player1.energy = 20;
        }
    }
}
