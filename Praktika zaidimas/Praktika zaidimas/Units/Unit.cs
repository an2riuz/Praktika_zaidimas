using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units
{
    class Unit
    {
        // Kintamieji
        
        protected int x;
        protected int y;
        private string name;

        // Konstruktorius
        public Unit(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Funkcijos
        public void PrintInfo()
        {
            Console.WriteLine($"Unit {name} is at {x}x{y}");
        }
    }
}
