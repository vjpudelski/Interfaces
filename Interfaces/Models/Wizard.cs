using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Wizard : ISpellCaster
    {
        public bool Prepare(Spell spellToPrepare)
        {
            bool spellPrepared = false;

            // code for the wizard to prepare the spell to be casted

            return spellPrepared;
        }

        public bool Cast(Spell spellToCast)
        {
            bool spellCasted = false;

            // code to cast the spell

            return spellCasted;
        }
    }
}
