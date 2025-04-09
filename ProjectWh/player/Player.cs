using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Player
    {
        public int HP { get; private set; }
        public int Attack { get; private set; }
        public Item EquipWeapon{ get; private set;}
        public int Gold { get; private set; }
        public Inventory Inventory { get; private set; }

        public Player()
        {
            HP = 100;
            Attack = 10;
            EquipWeapon = null;
            Gold = 0;
            Inventory = new Inventory();
        }

        public void GainGold(int amount)
        {
            Gold += amount;
            Console.WriteLine($"{amount} 골드획득 현재 소지 골드: {Gold}");
            
        }

        
    }
}
