using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    interface ISpellCaster
    {
        bool Prepare(Spell spellToPrepare);
        bool Cast(Spell spellToCast);
    }
}
