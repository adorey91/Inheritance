using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Console.WriteLine("-----------");
            Console.WriteLine();

            Player player = new Player();
            Enemy slime = new Enemy();
            Item sword = new Item();
            

            player.position.x = 0;
            player.position.y = 0;
            player.healthSystem.health = 100;

            slime.position.x = 10;
            slime.position.y = 10;
            slime.healthSystem.health = 50;

            sword.position.x = 15;
            sword.position.y = 15;

            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey(true);  
        }
    }
}
