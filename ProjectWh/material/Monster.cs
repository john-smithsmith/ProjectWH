using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Monster
    {
        public string Name { get; protected set; }
        public int HP { get; protected set; }
        public int Atk { get; protected set; }
        public Item DropItem { get; protected set; }
    }

    public class DummyScarecrow : Monster
    {
        public DummyScarecrow(Item dropItem)
        {
            Name = "연습용 허수아비";
            HP = 1000;
            Atk = 0; 
            DropItem = dropItem;
        }
    }
}
