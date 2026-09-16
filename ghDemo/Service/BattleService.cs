using ghDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghDemo.Service
{
    internal class BattleService
    {
        public void PrintBattle(Hero hero, Enemy enemy)
        {
            HealingService.Heal(hero);

            Console.WriteLine($"\n=== Battle Start ===\n\n");

            Console.WriteLine($"hero: {hero.Name} engages {enemy.Name}!");
        }
    }
}
