using Praktika_zaidimas.Units.Enemy;
using Praktika_zaidimas.Units.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.Screen
{
    class GameScreen
    {
        // Kintamieji
        private int width;
        private int height;

        private Hero hero;
        private List<enemies> enemies = new List<enemies>();

        // Konstruktorius
        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // Metodai
        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }
        public Hero GetHero()
        {
            return hero;
        }
        void AddEnemy(enemies enemy)
        {
            enemies.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach (enemies enemy in enemies)
            {
                enemy.MoveDown();
            }
        }
        public enemies GetEnemyByID(int id)
        {
            foreach (enemies enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }
        public void Render()
        {
            hero.PrintInfo();
            foreach (enemies enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
