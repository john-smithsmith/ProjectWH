using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class TitleScene : MainScene
    {
        public override void Render()
        {
            Console.WriteLine("타이틀화면출력");
            Console.WriteLine("타이틀화면출력");
            Console.WriteLine("시작할려면 아무키나 눌러주세요");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.ChangeScene("Start");
        }
    }
}
