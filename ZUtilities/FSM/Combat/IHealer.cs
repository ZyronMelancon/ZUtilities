using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUtilities.FSM.Combat
{
    interface IHealer
    {
        void Heal(IHealable other, int amount);
    }
}
