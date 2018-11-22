using Praktika_zaidimas.Screen;
using Praktika_zaidimas.Units.Enemy;
using Praktika_zaidimas.Units.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemyCount = 0;
            Random rnd = new Random();

            // Herojaus sukurimas
            Hero Herojus = new Hero(0, 10, "Karys");

            // Priesu sukurimas
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
            // Ekrano sukurimas
            GameScreen myGame = new GameScreen(80,30);
            myGame.SetHero(new Hero(5, 5, "HERO"));

            Herojus.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Herojus.MoveLeft();
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }

            Herojus.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            myGame.Render();

            myGame.GetHero().MoveLeft();
            myGame.MoveAllEnemiesDown();

            Enemy secondEnemy = myGame.GetEnemyByID(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            myGame.Render();
            Console.ReadKey();
        }
    }
}
