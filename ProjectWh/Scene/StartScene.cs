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
            Console.WriteLine("시작화면");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("여기는 허수아비 밖에 없는 세상입니다");
            Console.WriteLine("탈출하기 위해서는 최강의 허수아비를 이겨야 합니다");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("[1] 전부 부셔주겠다"); // 월드맵으로 이동
           
            
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
                
                
                    
            }
        }
    }
}
