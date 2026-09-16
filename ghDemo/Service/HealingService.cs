using ghDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghDemo.Service
{
    internal class HealingService
    {
        public static void Heal(Hero hero)
        {
            hero.Health = 150;
            Console.WriteLine("{0} healed", hero.Name);
        }
    }
}
