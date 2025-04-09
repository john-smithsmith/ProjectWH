using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class BossScene : MainScene
    {
        private ConsoleKey input;
        private Monster bossMonster;

        public BossScene()
        {
            bossMonster = MonsterFactory.CreateBossScarecrow(); 
            
        }

        public override void Render()
        {
            Console.WriteLine("보스룸");
            Console.WriteLine($"보스 몬스터: {bossMonster.Name} (HP: {bossMonster.Hp})");
            Console.WriteLine
                ($"플레이어 HP: {Game.player.HP}  공격력: {Game.player.Attack}");
            Console.WriteLine("--------------------");
            Game.player.Inventory.DisplayInventory(); // 인벤토리 표시
            Console.WriteLine("--------------------");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        public override void Result()
        {

        }
    }
}
