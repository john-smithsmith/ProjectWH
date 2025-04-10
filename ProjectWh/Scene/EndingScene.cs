using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh.Scene
{
    
    public class EndingScene : MainScene
        //움직이는 그림? frame?
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("=========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           게임 클리어           ");
            Console.ResetColor();
            Console.WriteLine(" ========================================");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|     ||        ------------|           |");
            Console.WriteLine("|     ||       |            |           |");
            Console.WriteLine("|     || ======|            |           |");
            Console.WriteLine("|     ||       |------------|           |");
            Console.WriteLine("|     ||                                |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("========================================");
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
            
            Console.ReadKey(true);
            Game.GameOver = true;
        }
    }
}
