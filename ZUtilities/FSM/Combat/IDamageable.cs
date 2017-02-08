using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUtilities.FSM.Combat
{
    interface IDamageable
    {
        void TakeDamage(int dam);
    }
}