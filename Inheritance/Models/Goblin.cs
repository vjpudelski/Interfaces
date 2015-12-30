using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Goblin : Creature
    {
        public Goblin(int startingLevel)
        {
            _level = startingLevel;
        }
    }
}
