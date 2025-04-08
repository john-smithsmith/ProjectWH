﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Cave01Scene : MainScene
    {
        private ConsoleKey input;
        private Monster monster;

       


        public override void Render()
        {
            Console.WriteLine("1번동굴");
            Console.WriteLine($"몬스터: {monster.Name} (HP: {monster.Hp})");
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
                Game.ChangeScene("Cave02");
                break;
            }
        }
    }
}
