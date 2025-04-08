using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public static class ItemFactory
    {
        public static Item CreateWoodSword()
        {
            return new WoodSword();
        }

        
    }

    public static class MonsterFactory
    {
        public static Monster CreateDummyScarecrow()
        {
            Item woodSword = ItemFactory.CreateWoodSword();
            return new DummyScarecrow(woodSword);
        }

        
    }
}
