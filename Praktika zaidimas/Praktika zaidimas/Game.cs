using Praktika_zaidimas.Units.Hero;
using Praktika_zaidimas.Units.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika_zaidimas.Screen;

namespace Praktika_zaidimas
{
    class Game
    {
        void StartGame()
        {
            int enemyCount = 0;
            Random rnd = new Random();

            // Herojaus sukurimas
            Hero Herojus = new Hero(0, 10, "Karys");

            // Priesu sukurimas
            List<enemies> enemies = new List<enemies>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new enemies(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
            // Ekrano sukurimas
            GameScreen myGame = new GameScreen(80, 30);
            myGame.SetHero(new Hero(5, 5, "HERO"));

            Herojus.PrintInfo();
            foreach (enemies enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Herojus.MoveLeft();
            foreach (enemies enemy in enemies)
            {
                enemy.MoveDown();
            }

            Herojus.PrintInfo();
            foreach (enemies enemy in enemies)
            {
                enemy.PrintInfo();
            }

            myGame.Render();

            myGame.GetHero().MoveLeft();
            myGame.MoveAllEnemiesDown();

            enemies secondEnemy = myGame.GetEnemyByID(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            //myGame.Render();
            bool needToRender = true;
            do
            {
                Console.Clear();
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.GetHero().MoveRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.GetHero().MoveLeft();
                            break;
                    }
                }
                myGame.Render();
                System.Threading.Thread.Sleep(250);
            } while (needToRender);

            // Console.ReadKey();
        }
    }
}
