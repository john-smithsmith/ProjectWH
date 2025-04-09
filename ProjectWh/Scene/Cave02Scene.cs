﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Cave02Scene : MainScene
    {
        private ConsoleKey input;
        private Monster monster;

        public Cave02Scene()
        {
            monster = MonsterFactory.CreateCave02Scarecrow(); 
            
        }
        public override void Render()
        {
            Console.WriteLine("2번동굴");      
            Console.WriteLine($"몬스터: {monster.Name} (HP: {monster.Hp})");
            Console.WriteLine
                ($"플레이어 HP: {Game.player.HP}," +//나중에 고칠것
                $" 공격력: {Game.player.Attack},");
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

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Cave03");
                    break;
            }
        }
    }
}
