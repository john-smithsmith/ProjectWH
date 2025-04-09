using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Item
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }

        public Item(string name, int price = 0)
        {
            Name = name;
            Price = price;
        }

    }


    public class AttackPotion : Item
    {
        public int AttackBonus { get; private set; }

        public AttackPotion(string name, int attackBonus, int price = 0) : base(name, price)
        {
            AttackBonus = attackBonus;
        }

        public void Use(Player player)
        {
            player.IncreaseAttack(AttackBonus);
            Console.WriteLine($"{Name}을 사용하여 공격력이 영구적으로 {AttackBonus}만큼 증가했습니다.");
        }
    }




    public class Gold : Item
    {
        public int Amount { get; private set; }

        public Gold(int amount) : base("골드")
        {
            Amount = amount;
        }
    }
}
