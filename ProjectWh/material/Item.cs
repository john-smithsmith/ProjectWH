﻿using System;
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
        public int AttackBonus { get;  set; }

        public AttackPotion(string name, int attackBonus, int price = 0) : base(name, price)
        {
            AttackBonus = attackBonus;
        }

        public void Use(Player player)
        {
            player.Attack += AttackBonus;
            
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

    public class BossKey : Item
    {
        public string BossRoomName { get; private set; }

        public BossKey(string name, string bossroomname) : base(name)
        {
            BossRoomName = bossroomname;
        }
    }

    }
