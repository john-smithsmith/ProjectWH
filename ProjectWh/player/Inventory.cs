using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Inventory
    {
        public List<Item> Items { get; private set; }
        public int Gold { get; private set; }//골드를 인벤토리에 표현하는게 더 깔끔해 보였음

        public Inventory()
        {
            Items = new List<Item>();
            Gold = 0;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine($"{item.Name}확득");
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            Console.WriteLine($"{item.Name}손실");
        }

        public void GetGold(int amount)
        {
            Gold += amount;
            Console.WriteLine($"{amount} 골드를 획득 현재 소지 골드: {Gold}");
        }

        public bool UseGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
                Console.WriteLine($"{amount} 골드를 사용 현재 소지 골드: {Gold}");
                return true;
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
                return false;
            }
        }

        public void UseItem(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex <= Items.Count)
            {
                Item selectedItem = Items[itemIndex - 1];

                if (selectedItem is AtkPotion potion)
                {
                    Game.player.Attack += potion.AttackIncrease;
                    RemoveItem(selectedItem); // 사용한 포션은 인벤토리에서 제거
                    Console.WriteLine($"{potion.Name}사용하여 공격력이 {potion.AttackIncrease} 증가 현재 공격력: {Game.player.Attack}");
                }
                else
                {
                    Console.WriteLine("해당 아이템은 사용할 수 없습니다.");
                }
            }
        }



        public void DisplayInventory()
        {
            Console.WriteLine("인벤토리:");
            Console.WriteLine($"소지 골드: {Gold}");
            if (Items.Count > 0)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"- {Items[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("비어있습니다");
            }
        }

    }
}