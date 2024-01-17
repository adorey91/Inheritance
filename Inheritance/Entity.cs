using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Entity : GameObject
    {
        public HealthSystem healthSystem;
        
        //constructor
        public Entity()
        {
            Console.WriteLine("Entity class constructed...");

            //instantiate health system
            healthSystem = new HealthSystem();
        }
    }
}
