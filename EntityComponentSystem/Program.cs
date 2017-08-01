using System;

namespace EntityComponentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = CreatePlayer();
            var monster = CreateMonster();

            Console.WriteLine("=========== Player ==============");
            Console.WriteLine("-> Id: {0}", player.Id);
            Console.WriteLine("-> Components:");
            Console.WriteLine("--> Position Component");
            Console.WriteLine("---> X = {0}", player.GetComponent<PositionComponent>().Position.X);
            Console.WriteLine("---> Y = {0}", player.GetComponent<PositionComponent>().Position.Y);
            Console.WriteLine("---> Z = {0}", player.GetComponent<PositionComponent>().Position.Z);
            Console.WriteLine("--> Velocity Component");
            Console.WriteLine("---> Speed = {0}", player.GetComponent<VelocityComponent>().Speed);

            Console.WriteLine("=========== Monster ==============");
            Console.WriteLine("-> Id: {0}", monster.Id);
            Console.WriteLine("-> Components:");
            Console.WriteLine("--> Position Component");
            Console.WriteLine("---> X = {0}", monster.GetComponent<PositionComponent>().Position.X);
            Console.WriteLine("---> Y = {0}", monster.GetComponent<PositionComponent>().Position.Y);
            Console.WriteLine("---> Z = {0}", monster.GetComponent<PositionComponent>().Position.Z);

            Console.ReadLine();
        }

        public static PlayerEntity CreatePlayer()
        {
            var player = EntityManager.CreateEntity<PlayerEntity>();
            var playerPosition = player.AddComponent(new PositionComponent());
            playerPosition.Position.X = 0;
            playerPosition.Position.Y = 5;
            playerPosition.Position.Z = 2;

            var playerVelocity = player.AddComponent(new VelocityComponent());
            playerVelocity.Speed = 10f;

            return player;
        }

        public static MonsterEntity CreateMonster()
        {
            var monster = EntityManager.CreateEntity<MonsterEntity>();
            var monsterPosition = monster.AddComponent(new PositionComponent());
            monsterPosition.Position.X = 2;
            monsterPosition.Position.Y = 3;
            monsterPosition.Position.Z = 4;

            return monster;
        }
    }
}