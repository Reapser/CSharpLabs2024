using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz4_5
{
    internal class Battle
    {
        UI_Ren render_ui = null;
        public Battle(PlayerMage player, EnemyMage enemy)
        {
            render_ui = new UI_Ren(enemy, player);
            BattleNow(player, enemy);
        }

        void BattleNow(PlayerMage player, EnemyMage enemy)
        {
            while (true)
            {
                render_ui.Render();
                player.Turn(enemy);
                if (enemy.HP <= 0)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"{player.Name} wins!");
                    System.Threading.Thread.Sleep(1500);
                    break;
                }
                enemy.Turn(player);
                if (player.HP <= 0)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"{enemy.Name} wins!");
                    System.Threading.Thread.Sleep(1500);
                    break;
                }

                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
