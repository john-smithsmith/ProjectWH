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
        public static Player player;


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
            player = new Player();//player


            sceneDic = new Dictionary<string, MainScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Start", new StartScene());//배경설명
            sceneDic.Add("WorldMap", new WorldMapScene());
            sceneDic.Add("Cave01", new Cave01Scene());//1번방-튜토리얼
            sceneDic.Add("Cave02", new Cave02Scene());
            sceneDic.Add("Cave03", new Cave03Scene());
            sceneDic.Add("Cave04", new Cave04Scene());
            sceneDic.Add("Boss", new BossScene());//보스룸
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
