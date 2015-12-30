using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Hydra : Creature
    {
        public Hydra(int startingLevel)
        {
            _level = startingLevel;
        }
    }
}
