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
            sceneDic.Add("Start", new StartScene());
            sceneDic.Add("Cave01", new Cave01Scene());
            sceneDic.Add("Boss", new BossScene());
            sceneDic.Add("Shop", new ShopScene());
            curScene = sceneDic["Title"];
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        private static void End()
        {

        }

    }
}
