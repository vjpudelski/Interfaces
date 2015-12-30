using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Creature
    {
        protected int _level;

        public void LevelUp()
        {
            _level++;
        }
    }
}
