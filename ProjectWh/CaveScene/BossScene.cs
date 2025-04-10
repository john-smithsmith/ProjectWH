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

        public BossScene()
        {
            monster = MonsterFactory.CreateBossScarecrow();

        }

        public override void Render()
        {
            Console.WriteLine("보스룸");

            Console.WriteLine($"보스 몬스터: {monster.Name} (HP: {monster.Hp})");

            Console.WriteLine
                ($"플레이어 HP: {Game.player.HP}  공격력: {Game.player.Attack}");
            Console.WriteLine("[E] 공격");
            Console.WriteLine("[0] 월드맵으로 이동");

            Console.WriteLine("--------------------");
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시
            Console.WriteLine("--------------------");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            if (monster.Hp > 0)
            {

            }
            else
            {
                Console.WriteLine($"game claer");
                Console.ReadKey(true);
               
                Game.GameOver = true;
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
