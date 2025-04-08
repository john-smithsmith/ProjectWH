using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWh
{
    public class Cave01Scene : MainScene
    {
        private ConsoleKey input;
        private Monster monster;

        public Cave01Scene()
        {
            monster = MonsterFactory.CreateCave01Scarecrow();
            
        }


        public override void Render()
        {
            Console.WriteLine("1번동굴");
            Console.WriteLine($"몬스터: {monster.Name} (HP: {monster.Hp})");
            Console.WriteLine
                ($"플레이어 HP: {Game.player.HP}," +//나중에 고칠것
                $" 공격력: {Game.player.Attack}," +
                $" 소지 골드: {Game.player.Gold}");
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
            switch (input)
            { 
                case ConsoleKey.D1:
                Game.ChangeScene("Cave02");
                break;
            }
        }
    }
}
