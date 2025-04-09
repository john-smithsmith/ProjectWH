using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class ShopScene : MainScene
    {
        private ConsoleKey input;
        private Item rustSword;
        private int rustSwordPrice = 5; // 녹슨 검 가격
        private Item ironSword;
        private int ironSwordPrice = 10; // 강철 검 가격



        public ShopScene()
        {
            rustSword = ItemFactory.CreateRustSword();
            ironSword = ItemFactory.CreateIronSword();
        }


        public override void Render()
        {
            Console.WriteLine("상점");
            Console.WriteLine("-----");
            Console.WriteLine($"[2] {rustSword.Name} (가격: {rustSwordPrice} 골드)");
            Console.WriteLine($"[3] {ironSword.Name} (가격: {ironSwordPrice} 골드)");
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
                    Game.ChangeScene("");
                    break;

                case ConsoleKey.D2:
                    BuyItem(rustSword, rustSwordPrice);
                    break;
                case ConsoleKey.D3:
                    BuyItem(ironSword, ironSwordPrice);
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
            }
            
            Console.ReadKey(true);
        }




    }
}
