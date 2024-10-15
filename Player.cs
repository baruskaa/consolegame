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
        public int health = 10;
        public int energy = 5;
        public int damage = 1;
        public int weaponValue = 1;
        public int amuletValue = 0;
        public int potionCount = 1;

        public void resetAttributes()
        {
            Program.player1.health = 10;
            Program.player1.energy = 5;
            Program.player1.damage = 1;
            Program.player1.weaponValue = 1;
            Program.player1.amuletValue = 0;
            Program.player1.potionCount = 0;
        }
    }
}
