using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public static class ItemFactory
    {
       
    }

    public static class MonsterFactory
    {
       

        
        public static Monster CreateCave01Scarecrow()// 1번 방 허수아비
        {
            return new DummyScarecrow("연습용 허수아비", 1000, new Gold(50));
        }

        
        public static Monster CreateCave02Scarecrow()// 2번 방 허수아비
        {
            return new DummyScarecrow("강한 허수아비", 2000, new Gold(50)); 
        }

        
        public static Monster CreateCave03Scarecrow()// 3번 방 허수아비
        {
            return new DummyScarecrow("매우 강한 허수아비", 3000, new Gold(50)); 
        }

        
        public static Monster CreateCave04Scarecrow()// 4번 방 허수아비
        {
            return new DummyScarecrow("엄청 매우 강한 허수아비", 4000, new Gold(50)); 
        }

        
        public static Monster CreateBossScarecrow()// 보스 허수아비
        {
            return new DummyScarecrow("보스 허수아비", 5000, new Gold(50)); 
        }
    }
}
