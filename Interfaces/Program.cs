using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Spell someSpell = new Spell();

            ISpellCaster caster = new Wizard();
            caster.Prepare(someSpell);
            caster.Cast(someSpell);
        }
    }
}
