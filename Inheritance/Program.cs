using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature1 = new Goblin(1);
            Creature creature2 = new Ogre(1);
            Creature creature3 = new Hydra(1);

            creature1.LevelUp();
            creature2.LevelUp();
            creature3.LevelUp();
        }
    }
}
