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
            return orcs.Count==0;
        }

        public override void LeaveDead()
        {
            UniqueList<Orc> orcsToBury=new UniqueList<Orc>();
            foreach (Orc orc in orcs)
            {
                if (!orc.IsAlive())
                {
                    orcsToBury.Add(orc);
                }
            }

            foreach(Orc orc in orcsToBury)
            {
                orcs.Remove(orc);
            }
        }

    }
}
