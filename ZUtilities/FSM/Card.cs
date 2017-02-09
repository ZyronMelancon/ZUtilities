using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUtilities.FSM.Combat;

namespace ZUtilities.FSM
{
    class Card : IDamager
    {
        string m_name;
        string m_type;
        string m_desc;

        int power;


        public void GiveDamage(IDamageable other)
        {
            other.TakeDamage(power);
        }

        public void GiveDamage(IDamageable other, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
