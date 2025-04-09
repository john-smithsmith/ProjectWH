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

            WeaponAtk = 10;
        }
    }

    public class AtkPotion : Item
    {
        public int AttackIncrease { get; private set; }

        public AtkPotion(int attackIncrease)
            AttackIncrease = attackIncrease;
    }


    public class Gold : Item
    {
        public int Amout { get; private set; }
        public Gold(int amount)
        {
            Name = "골드";
            Amout = amount;
        }
    }
}
