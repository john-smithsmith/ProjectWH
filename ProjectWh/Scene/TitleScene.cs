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
            Console.WriteLine(" ========================================");
            Console.WriteLine("|             허수아비 부수기            |");
            Console.WriteLine(" ========================================");
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
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|         [Press anykey to start]       |");
            Console.WriteLine("========================================");
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
