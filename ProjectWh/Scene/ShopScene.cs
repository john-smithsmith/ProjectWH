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
        private AttackPotion forSalePotion;

        public ShopScene()
        {
           
            forSalePotion = new AttackPotion("공격력 포션", 10, 150);
        }

        public override void Render()
        {
            Console.Clear(); // 콘솔 화면 지우기
            Console.WriteLine("상점");
            Console.WriteLine("--------------------");
            Console.WriteLine($"[1] {forSalePotion.Name} - {forSalePotion.Price} 골드");

            Console.WriteLine("[0] 나가기");
            Console.WriteLine("--------------------");
            Console.WriteLine
               ($"플레이어 HP: {Game.player.HP} 공격력: {Game.player.Attack},");
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
                    BuyAndUsePotion(forSalePotion, forSalePotion.Price);
                    break;
                case ConsoleKey.D0:
                    Game.ChangeScene("WorldMap");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadKey(true);
                    Game.ChangeScene("Shop");
                    break;

            }
        }

        private void BuyAndUsePotion(AttackPotion potion, int price)
        {
            if (Game.player.Inventory.UseGold(price))
            {
                potion.Use(Game.player); 
                Console.WriteLine($"{potion.Name} 구매하여 사용했습니다. 공격력이 {potion.AttackBonus}만큼 증가했습니다.");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
        }





    }
}
