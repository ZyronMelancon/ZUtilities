using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUtilities.FSM
{
    class CombatMachine
    {
        int m_phase;
        Dictionary<string, IState> States;
        List<Party> Parties;

        public int Phase { get { return m_phase; } }

        public void ExecuteState(IState current)
        {

        }

        public void ChangeState(string a, string b)
        {

        }
    }

    class Init : IState
    {
        public void ThisStateFunction()
        {
            
        }
    }
}
