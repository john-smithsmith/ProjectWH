using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class BossScene : MainScene
    {
        private ConsoleKey input;
        private Monster monster;
        private bool bossDied = false;

        public BossScene()
        {
            monster = MonsterFactory.CreateBossScarecrow();

        }

        public override void Render()
        {
            Console.WriteLine("");
            Console.WriteLine("보스동굴");
            Console.WriteLine("=========================================");
            Console.WriteLine($"    몬스터: {monster.Name}        ");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                 ------                |");
            Console.WriteLine("|               ||      ||              |");
            Console.WriteLine("|               ||      ||              |");
            Console.WriteLine("|               ||      ||              |");
            Console.WriteLine("|               ||      ||              |");
            Console.WriteLine("|               ||      ||              |");
            Console.WriteLine("|               ---------               |");
            Console.WriteLine("|                   ||                  |");
            Console.WriteLine("|                   ||                  |");
            Console.WriteLine("|                ========               |");
            Console.WriteLine($"|                HP: {monster.Hp}                |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[E] 공격                                ");
            Console.WriteLine("[0] 월드맵으로 이동                     ");
            Console.ResetColor();
            Console.WriteLine("========================================");
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시
            Console.WriteLine("========================================");
            Console.WriteLine($"플레이어 HP: {Game.player.HP} 공격력: {Game.player.Attack}");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            if (monster.Hp <= 0)
            {
                if (monster.Hp <= 0 && !bossDied)
                {
                    bossDied = true;
                    Console.WriteLine("당신은 승리하였다");
                }


            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.E:
                    if (monster.Hp > 0)
                    {
                        Game.player.AttackMonster(monster);
                    }
                    else if (bossDied) 
                    {
                        Console.ReadKey(true); 
                        Game.ChangeScene("Ending");
                    }
                    break;
                case ConsoleKey.D0:
                    Game.ChangeScene("WorldMap");
                    break;
                default:
                    Game.ChangeScene("Boss");
                    break;

                
            }
        }
    }
}
