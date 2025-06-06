﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Cave03Scene : MainScene
    {
        private ConsoleKey input;
        private Monster monster;


        public Cave03Scene()
        {
            monster = MonsterFactory.CreateCave03Scarecrow();
           
        }


        public override void Render()
        {
            Console.WriteLine("");
            Console.WriteLine("3번동굴");
            Console.WriteLine("=========================================");
            Console.WriteLine($"         몬스터: {monster.Name}        ");
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
            if (monster.Hp > 0)
            {

            }
            else
            {
                Console.WriteLine($"{monster.Name} 처치했습니다!");

                monster = MonsterFactory.CreateCave03Scarecrow();
                Console.WriteLine("새로운 허수아비가 나타났습니다!");
                Console.ReadKey(true);
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
                    Game.ChangeScene("Cave01");
                    break;
            }
        }
    }
}
