using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    
    public class StartScene : MainScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("게임 시작");
            Console.WriteLine("-----");
            Console.WriteLine("[1] 모험을 떠난다"); // 월드맵으로 이동
            Console.WriteLine("[2] 상점으로 간다");
            Console.WriteLine("[0] 종료");
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
                    Game.ChangeScene("WorldMap"); // 월드맵으로 이동
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Shop");
                    break;
                
                    
            }
        }
    }
}
