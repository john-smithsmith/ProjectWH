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
            if (item is Gold gold)
            {
                Gold += gold.Amount;
                Console.WriteLine($"{gold.Amount} 골드를 획득했습니다 현재 골드: {Gold}");
            }
            else
            {
                Items.Add(item);
                Console.WriteLine($"{item.Name} 획득");
            }
        }

        public void RemoveItem(Item item)
        {
            if (item is Gold gold)
            {
                if (Gold >= gold.Amount)
                {
                    Gold -= gold.Amount;
                    Console.WriteLine($"{gold.Amount} 골드를 잃었습니다 현재 골드: {Gold}");
                }
                
            }
            else
            {
                Items.Remove(item);
                Console.WriteLine($"{item.Name} 손실");
            }
        }

        public void GetGold(int amount)
        {
            Gold += amount;
            Console.WriteLine($"{amount} 골드를 획득 현재 골드: {Gold}");
        }

        public bool UseGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
                Console.WriteLine($"{amount} 골드를 사용 현재 골드: {Gold}");
                return true;
            }
            else
            {
                Console.WriteLine("골드가 부족합니다.");
                return false;
            }
        }

       



        public void DisplayInventory()
        {
            Console.WriteLine("인벤토리:");
            Console.WriteLine($"소지 골드: {Gold}");
            if (Items.Count > 0)
            {
                Console.WriteLine("아이템 목록:");
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