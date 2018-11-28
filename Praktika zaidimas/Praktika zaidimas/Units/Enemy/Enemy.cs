﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Units.Enemy
{
    class Enemy : Unit
    {

        private int id;

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;
        }

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
