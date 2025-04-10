using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectWh
{
    public class Player
    {
        public int HP { get; private set; }
        public int Attack { get; set; }


        public Inventory Inventory { get; private set; }
        //장비 아이템?


        public Player()
        {
            HP = 100;
            Attack = 10;

            Inventory = new Inventory();


        }

        public void IncreaseAttack(int bonus)
    {
        Attack += bonus;
    }

        public void AttackMonster(Monster monster)
        {
            Console.WriteLine($"{monster.Name} {Attack} 데미지");
            monster.Hp -= Attack; 
            Console.WriteLine($"{monster.Name}의 남은 체력: {monster.Hp}");

            if (monster.Hp <= 0)
            {
                Console.WriteLine($"{monster.Name} 처치");
                if (monster.DropItem != null)
                {
                    Console.WriteLine($"{monster.Name} {monster.DropItem.Name} 드랍");
                    Inventory.AddItem(monster.DropItem); // 인벤토리에 아이템 추가
                    if (monster.DropItem is Gold gold)
                    {
                        Inventory.GetGold(gold.Amount); // 골드 획득 시 인벤토리의 골드 증가
                    }
                }

            }

        }
    }
}