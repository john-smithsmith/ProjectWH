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
            Console.WriteLine($"{monster.Name}를 {Attack}의 데미지로 공격했습니다!");
            monster.Hp -= Attack; // 플레이어의 공격력만큼 몬스터의 HP 감소
            Console.WriteLine($"{monster.Name}의 남은 체력: {monster.Hp}");

            if (monster.Hp <= 0)
            {
                Console.WriteLine($"{monster.Name}을(를) 처치했습니다!");
                if (monster.DropItem != null)
                {
                    Console.WriteLine($"{monster.Name}이(가) {monster.DropItem.Name}을(를) 드랍했습니다.");
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