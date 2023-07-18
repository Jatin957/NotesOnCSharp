using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class player
    {
        public string name = "Demon";
        private int health = 55;

        public int  gethealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
}
