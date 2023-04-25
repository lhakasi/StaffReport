using System;
using System.Collections.Generic;
using System.Linq;

namespace StaffReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();

            terminal.Work();
        }
    }

    class Soldier
    {
        private string _weapon;

        private int _servicLife;

        public Soldier(string name, string rank, string weapon, int servicLife)
        {
            Name = name;
            Rank = rank;
            _weapon = weapon;
            _servicLife = servicLife;
        }

        public string Name { get; private set; }
        public string Rank { get; private set; }
    }

    class Terminal
    {
        private List<Soldier> _soldiers;

        public Terminal()
        {
            _soldiers = new List<Soldier>()
            {
                new Soldier("Терентьев", "Капитан", "Винтовка", 120),
                new Soldier("Мельников", "Полковник", "Пистолет", 210),
                new Soldier("Подольских", "Лейтенант", "Автомат", 90),
                new Soldier("Павлов", "Майор", "Пистолет", 184),
                new Soldier("Хлебников", "Полковник", "Пистолет", 240),
                new Soldier("Воробьев", "Ст. Лейтенант", "Автомат", 110),
                new Soldier("Балош", "Капитан", "Винтовка", 135),
                new Soldier("Захаров", "Подполковник", "Пистолет", 200),
                new Soldier("Сотников", "Ст. Лейтенант", "Автомат", 105)
            };
        }

        public void Work()
        {
            ShowFilteredSoldiers();
        }

        private void ShowFilteredSoldiers()
        {
            var filteredInfo = _soldiers.Select(soldier => new { soldier.Name, soldier.Rank }).ToList();
            
            filteredInfo.ForEach(soldier => Console.WriteLine($"{soldier.Name} - {soldier.Rank}"));

            Console.ReadKey();
        }
    }
}
