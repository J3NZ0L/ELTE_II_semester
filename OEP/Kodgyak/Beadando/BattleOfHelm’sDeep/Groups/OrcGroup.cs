using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHelm_sDeep.Groups
{
    public class OrcGroup : Group
    {
        public UniqueList<Orc> orcs;

        public OrcGroup(UniqueList<Orc> orcs)
        {
            this.orcs = orcs;
        }

        public override bool AllDead()
        {
            return orcs == null;
        }

        public override void LeaveDead()
        {
            foreach(Orc orc in orcs)
            {
                if (!orc.IsAlive())
                {
                    orcs.Remove(orc);
                }
            }
        }
    }
}
