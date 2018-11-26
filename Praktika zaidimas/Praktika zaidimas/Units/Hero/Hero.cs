using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units.Hero
{
    class Hero : Unit { 
       
        // Konstruktorius
        public Hero(int x, int y, string name) : base(x,y,name)
        {
            
        }
        // Funkcijos
        public void MoveRight()
        {
            x++;
        }
        public void MoveLeft()
        {
            x--;
        }
    }
}
