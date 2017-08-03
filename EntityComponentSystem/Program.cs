using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityComponentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Entity Component System =====");

            Task.Run(() => UpdateSystems());



            Console.ReadLine();
        }

        private static List<System> _systems = new List<System>();

        static void UpdateSystems()
        {
            while (true)
            {
                foreach (var system in _systems)
                {
                    system.Update();
                }
            }
        }
    }
}