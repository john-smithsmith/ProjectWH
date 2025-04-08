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
            while (GameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }

        private static void Start()
        {
            GameOver = false;
            sceneDic = new Dictionary<string, MainScene>();
        }

        private static void End()
        {

        }

    }
}
