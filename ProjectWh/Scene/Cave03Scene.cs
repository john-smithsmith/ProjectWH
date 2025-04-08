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
        public override void Render()
        {
            Console.WriteLine("3번동굴");
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
                    Game.ChangeScene("Cave04");
                    break;
            }
        }
    }
}
