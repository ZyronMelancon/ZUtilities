using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZUtilities.FSM.Combat;

namespace ZUtilities.FSM
{
    class Player : IDamageable, IDamager, IHealable
    {
        //Player parameters
        string m_name;
        Dictionary<string, int> m_stats;
        Dictionary<Item, int> m_inv;

        public string Name { get { return m_name; } set { m_name = value; } }
        public Dictionary<string, int> Stats { get { return m_stats; } set { m_stats = value; } }
        public Dictionary<Item, int> Inventory { get { return m_inv; } set { m_inv = value; } }

        //Player construction functions
        public void AddStat(string name, int val)
        {
            Stats.Add(name, val);
        }

        public void RemoveStat(string name)
        {
            Stats.Remove(name);
        }

        public void AlterStat(string name, int val)
        {
            Stats[name] += val;
        }

        public void AddItem(Item item, int amount)
        {
            if (Inventory.ContainsKey(item))
                Inventory[item] += amount;
            else
                Inventory.Add(item, amount);
        }

        public void RemoveItem(Item item, int amount)
        {
            if (Inventory.ContainsKey(item))
            {
                if (Inventory[item] >= amount)
                    Inventory[item] -= amount;
                if (Inventory[item] <= 0)
                    Inventory.Remove(item);
            }
        }

        public void GiveDamage(IDamageable other, int amount)
        {
            other.TakeDamage(amount);
        }

        public void TakeDamage(int dam)
        {
            Stats["Health"] -= dam;
        }

        public void RestoreHealth(int amount)
        {
            Stats["Health"] += amount;
        }


        public Player(string name)
        {
            Name = name;
            Stats.Add("Health", 100);
            Stats.Add("Mana", 25);
            Stats.Add("Speed", 10);
            Stats.Add("Attack", 15);
            Stats.Add("Defense", 15);
        }
    }
}
