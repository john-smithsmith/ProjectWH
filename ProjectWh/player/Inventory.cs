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
        public Inventory()
        {
            Items = new List<Item>();
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

        public void DisplayInventory()
        {
            Console.WriteLine("인벤토리:");
            if (Items.Count > 0)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"- {Items[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("인벤토리가 없음");
            }
        }

    }
}