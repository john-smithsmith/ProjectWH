﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class ShopScene : MainScene
    {
        private ConsoleKey input;
        private Item AtkPotion;
        private int AtkPotionPrice = 15;



        public ShopScene()
        {
            AtkPotion = ItemFactory.CreateAtkPotion(10)
        }


        public override void Render()
        {
            Console.WriteLine("상점");
            Console.WriteLine("-----");
            Console.WriteLine($"[1] 공격력포션 (가격: {AtkPotionPrice} 골드)");
            
            Console.WriteLine("[0] 나가기");
            Console.WriteLine("--------------------");
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시

            Console.WriteLine("--------------------");
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
                    
                    BuyItem(AtkPotion, AtkPotionPrice);
                    break;

              
                case ConsoleKey.D0:
                    Game.ChangeScene("");
                    break;

            }
        }

        private void BuyItem(Item item, int price)
        {
            if (Game.player.Inventory.UseGold(price))
            {
                Game.player.Inventory.AddItem(item);
                Console.WriteLine($"{item.Name}을(를) {price} 골드에 구매했습니다.");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
            
            Console.ReadKey(true);
        }




    }
}
