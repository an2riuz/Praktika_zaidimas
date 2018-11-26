using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units.Enemy
{
    class enemies : Unit
    {
        protected int id;
        // Konstruktorius
        public enemies(int id,int x, int y, string name) : base(x,y,name)
        {
            this.id = id;
        }

        // Funkcijos
        public void MoveDown()
        {
            y++;
        }
        public int GetId()
        {
            return id;
        }
    }
}
