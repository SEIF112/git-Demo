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
        public void PrintBattle(Weapon weapon, Hero hero, Enemy enemy)
        {
            Console.WriteLine($"Hero: {hero.Name}, Health: {hero.Health}");
            Console.WriteLine($"Enemy: {enemy.Name}, Health: {enemy.Health}");

            Console.WriteLine($"hero: {hero.Name} fights {enemy.Name}!");
            Console.WriteLine($"hero: {hero.Name} attacks {enemy.Name} with {weapon.Name}")
            Console.WriteLine($"{enemy.health} is reduced by {weapon.Damage}")
        }
    }
}
