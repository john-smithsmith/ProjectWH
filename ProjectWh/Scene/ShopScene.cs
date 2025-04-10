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
        private AttackPotion ShopPotion;
        private BossKey ShopBossKey;
        private string shopName = "아이템 상점";

        public ShopScene()
        {

            ShopPotion = new AttackPotion("공격력 포션", 10, 150);
            ShopBossKey = new BossKey("보스룸키", "BossScene");
        }

        public override void Render()
        {
            Console.Clear(); // 콘솔 화면 지우기
            Console.WriteLine("========================================");
            Console.WriteLine($"           <{shopName}>           ");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("어서 오세요! ");
            Console.WriteLine("중요한 물건은 여기 다 있습니다!");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("------------------ 판매 목록 ------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[1] {ShopPotion.Name} - {ShopPotion.Price} 골드");
            Console.WriteLine($"[2] {ShopBossKey.Name} - {1000} 골드");
            Console.WriteLine("[0] 나가기");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------");
           
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"플레이어 HP: {Game.player.HP} 공격력: {Game.player.Attack}");
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
                    BuyAndUsePotion(ShopPotion, ShopPotion.Price);
                    break;

                case ConsoleKey.D2:
                    BuyItem(ShopBossKey, 10);
                    break;

                case ConsoleKey.D0:
                    Game.ChangeScene("WorldMap");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다");
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
                Console.WriteLine($"{potion.Name} 구매했습니다 공격력이 {potion.AttackBonus} 증가했습니다");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
        }

        private void BuyItem(Item item, int price)
        {
            if (Game.player.Inventory.UseGold(price))
            {
                Game.player.Inventory.AddItem(item);
                Console.WriteLine($"{item.Name} {price} 골드에 구매했습니다");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }
            else
            {
                Console.WriteLine("골드가 부족");
                Console.ReadKey(true);
                Game.ChangeScene("Shop");
            }



        }
    }
}
