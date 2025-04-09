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

        public static Item CreateAtkPotion(int attackIncrease)
        {
            return new AtkPotion(attackIncrease);
        }


        public static Item CreateGold(int amount)
        {
            return new Gold(amount);
        }
    }

    public static class MonsterFactory
    {
        public static Monster CreateDummyScarecrow(string name, int hp, Item dropItem = null)
        {
            return new DummyScarecrow(name, hp, dropItem);
        }

        // 1번 방 허수아비
        public static Monster CreateCave01Scarecrow()
        {
            return new DummyScarecrow("연습용 허수아비", 1000, new Gold(50));
        }

        // 2번 방 허수아비
        public static Monster CreateCave02Scarecrow()
        {
            return new DummyScarecrow("강한 허수아비", 2000, new Gold(50)); 
        }

        // 3번 방 허수아비
        public static Monster CreateCave03Scarecrow()
        {
            return new DummyScarecrow("매우 강한 허수아비", 3000, new Gold(50)); 
        }

        // 4번 방 허수아비
        public static Monster CreateCave04Scarecrow()
        {
            return new DummyScarecrow("엄청 매우 강한 허수아비", 4000, new Gold(50)); 
        }

        // 보스 허수아비
        public static Monster CreateBossScarecrow()
        {
            return new DummyScarecrow("보스 허수아비", 5000, new Gold(50)); 
        }
    }
}
