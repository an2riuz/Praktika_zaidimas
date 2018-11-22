using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units.Hero
{
    class Hero
    {
        // Kintamieji
        private int x;
        private int y;
        private string name;

        // Konstruktorius
        public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
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
        public void PrintInfo()
        {
            Console.WriteLine($" Hero {name} is at {x}x{y}");
        }


    }
}
