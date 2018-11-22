using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units.Enemy
{
    class Enemy
    {
        // Kintamieji
        private int id;
        private int x;
        private int y;
        private string name;

        // Konstruktorius
        public Enemy(int id,int x, int y, string name)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Funkcijos
        public void MoveDown()
        {
            y++;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Enemy {name} is at {x}x{y}");
        }
        public int GetId()
        {
            return id;
        }
    }
}
