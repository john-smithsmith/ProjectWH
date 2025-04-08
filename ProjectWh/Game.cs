using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public static class Game
    {
        private static Dictionary<string, MainScene> sceneDic;
        private static MainScene curScene;
        private static bool GameOver;
        public static void Run()

        {
            Start();
            while (GameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
            End();
        }

        private static void Start()
        {
            GameOver = false;
            sceneDic = new Dictionary<string, MainScene>();
            sceneDic.Add("Title", new TitleScene());
            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }

    }
}
