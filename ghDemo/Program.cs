using ghDemo.Models;
using ghDemo.Service;

namespace ghDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero Bob = new() { Name = "Bob", Health = 100 };
            Enemy Goblin = new() { Name = "Goblin", Health = 50 };

            BattleService battleService = new BattleService();

            battleService.PrintBattle(Bob, Goblin);
        }
    }
}
