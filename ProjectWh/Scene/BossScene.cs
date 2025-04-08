using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class BossScene : MainScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("보스룸");
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

        }
    }
}
