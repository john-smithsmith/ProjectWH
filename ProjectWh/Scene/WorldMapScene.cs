using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class WorldMapScene : MainScene
    {
        private ConsoleKey input;
        private string[,] mapGrid;
        private int playerX;
        private int playerY;


        public WorldMapScene()
        {

            mapGrid = new string[,]
            {
            {"#", "#", "#", "#", "#", "#", "#"},
            {"#", ".", ".", ".", ".", ".", "#"},
            {"#", ".", ".", ".", ".", ".", "#"},
            {"#", ".", ".", ".", ".", "C", "#"},
            {"#", "#", "#", "#", "#", "#", "#"}
            };

            // 플레이어
            playerX = 1;
            playerY = 1;
        }

        public override void Render()
        {

            Console.WriteLine("===== 월드 맵 =====");


            for (int y = 0; y < mapGrid.GetLength(0); y++)
            {
                for (int x = 0; x < mapGrid.GetLength(1); x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.Write("P ");
                    }
                    else
                    {
                        Console.Write(mapGrid[y, x] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("[W/A/S/D] 이동");
            Console.WriteLine("[E]");

            Console.WriteLine("--------------------");
        }


        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            int newX = playerX;
            int newY = playerY;

            switch (input)
            {
                case ConsoleKey.W:
                    newY--;
                    break;
                case ConsoleKey.A:
                    newX--;
                    break;
                case ConsoleKey.S:
                    newY++;
                    break;
                case ConsoleKey.D:
                    newX++;
                    break;
            }

            if (newX >= 0 && newX < mapGrid.GetLength(1) &&
            newY >= 0 && newY < mapGrid.GetLength(0) &&
            mapGrid[newY, newX] != "#")
            {
                playerX = newX;
                playerY = newY;
            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.E:
                    if (mapGrid[playerY, playerX] == "C")
                    {
                        Console.WriteLine("동굴로 들어갑니다...");
                        ConsoleKey enterInput = Console.ReadKey(true).Key;
                        if (enterInput == ConsoleKey.E)
                        {
                            Game.ChangeScene("Cave01");
                        }
                    }
                    break;


            }
        }
    }
}
