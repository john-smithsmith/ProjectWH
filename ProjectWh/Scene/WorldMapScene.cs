﻿using System;
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
        // 로그라이크식 랜덤맵? random?
        // 몹 처치시 길 오픈? remove?
        public WorldMapScene()
        {

            mapGrid = new string[,]
        {
                 {"      ","#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
                 {"      ","#", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#", ".", "#"},
                 {"      ","#", ".", "1", ".", ".", ".", ".", ".", ".", ".", "#", "2", "#"},
                 {"      ","#", "#", "#", "#", "#", ".", ".", ".", ".", ".", "#", ".", "#"}, // C1: 동굴 1, S: 상점, C2: 동굴 2
                 {"      ","#", ".", ".", ".", ".", "#", "#", "#", ".", ".", ".", ".", "#"},
                 {"      ","#", ".", ".", ".", ".", ".", "S", "#", ".", ".", ".", ".", "#"},
                 {"      ","#", ".", ".", ".", ".", "#", "#", "#", ".", ".", ".", ".", "#"},
                 {"      ","#", "3", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                 {"      ","#", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#", ".", "#"}, // C3: 동굴 3, B: 보스 방, C4: 동굴 4
                 {"      ","#", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#", ".", "#"},
                 {"      ","#", ".", ".", ".", ".", ".", "#", "#", "#", ".", "#", "B", "#"},
                 {"      ","#", ".", ".", ".", ".", ".", ".", "4", ".", ".", "#", ".", "#"},
                 {"      ","#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"}
        };

            // 플레이어
            playerX = 1;
            playerY = 1;
        }

        public override void Render()
        {

            Console.WriteLine("=============== 월드 맵 ===============");


            for (int y = 0; y < mapGrid.GetLength(0); y++)
            {
                for (int x = 0; x < mapGrid.GetLength(1); x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("P ");
                        Console.ResetColor();
                    }
                    else if (mapGrid[y, x] == "#")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("# ");
                        Console.ResetColor();
                    }
                    else if (mapGrid[y, x] == "1" || mapGrid[y, x] == "2" || mapGrid[y, x] == "3" || mapGrid[y, x] == "4" || mapGrid[y, x] == "B" || mapGrid[y, x] == "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.Write(mapGrid[y, x] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(mapGrid[y, x] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|            [W/A/S/D] 이동            |");
            Console.WriteLine("|                  [E] 입장            |");
            Console.ResetColor();
            Console.WriteLine("========================================");
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시
            Console.WriteLine("========================================");
            Console.WriteLine($"플레이어 HP: {Game.player.HP} 공격력: {Game.player.Attack}");
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
                    string NowGrid = mapGrid[playerY, playerX];
                    switch (NowGrid)
                    {
                        case "1":
                            Console.WriteLine("동굴 1로 들어갑니다");
                            Game.ChangeScene("Cave01");
                            break;
                        case "2":
                            Console.WriteLine("동굴 2로 들어갑니다");
                            Game.ChangeScene("Cave02");
                            break;
                        case "3":
                            Console.WriteLine("동굴 3로 들어갑니다");
                            Game.ChangeScene("Cave03");
                            break;
                        case "4":
                            Console.WriteLine("동굴 4로 들어갑니다");
                            Game.ChangeScene("Cave04");
                            break;
                        case "B":
                            bool hasBossKey = false;
                            foreach (var item in Game.player.Inventory.Items)
                            {
                                if (item is BossKey && ((BossKey)item).BossRoomName == "BossScene")
                                {
                                    hasBossKey = true;
                                    break;
                                }
                            }
                            if (hasBossKey)
                            {
                                Game.ChangeScene("Boss");
                                Console.WriteLine("보스 방으로 들어갑니다");
                            }
                            else
                            {
                                Console.WriteLine("열쇠가 없습니다");
                                Console.ReadKey(true); 
                            }
                            break;

                            Game.ChangeScene("Boss");
                            break;
                        case "S":
                            Console.WriteLine("상점으로 들어갑니다");
                            Game.ChangeScene("Shop");
                            break;
                    }
                    break;
            }
        }
    }
}
