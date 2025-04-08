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
        
    }

    public class WoodSword : Item
    {
        public int WeaponAtk { get; private set; }

        public WoodSword()
        {
            Name = "목검";
            
            WeaponAtk = 5; // 목검의 공격력 보너스
        }
    }
}
