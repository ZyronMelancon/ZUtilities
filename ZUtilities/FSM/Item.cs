using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUtilities.FSM.Combat;

namespace ZUtilities.FSM
{
    public enum ItemTypes
    {
        Heal = 0,
        Damage = 1,
        Speed = 2,
        Mana = 3
    }

    class Item : IHealer, IDamager
    {
        string m_name;
        string m_desc;
        int m_type;
        int m_pwr;
        bool m_stack;

        public string Name { get { return m_name; } set { m_name = value; } }
        public string Description { get { return m_desc; } set { m_desc = value; } }
        public int Type { get { return m_type; } set { m_type = value; } }
        public int Power {  get { return m_pwr; } set { m_pwr = value; } }
        public bool Stackable { get { return m_stack; } set { m_stack = value; } }

        public void Heal(IHealable other, int amount)
        {
            other.RestoreHealth(amount);
        }

        public void GiveDamage(IDamageable other, int amount)
        {
            other.TakeDamage(amount);
        }

        public void Use(Player directed)
        {
            switch (m_type)
            {
                case (int)ItemTypes.Heal:
                    Heal(directed, Power);
                    break;
                case (int)ItemTypes.Damage:
                    GiveDamage(directed, Power);
                    break;
                //case (int)ItemTypes.Mana:
                //    break;
                //case (int)ItemTypes.Speed:
                //    break;
                default:
                    break;
            }
        }
    }
}
