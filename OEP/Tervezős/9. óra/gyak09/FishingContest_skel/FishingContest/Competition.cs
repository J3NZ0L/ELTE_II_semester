using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public class Competition
    {
        public class RegistrationException : Exception
        {
            public RegistrationException() {
            }
            public RegistrationException(string message) : base(message) { }

            public RegistrationException(string message,Exception innerexception) : base(message,innerexception) { }
        }

        public string Location { get; private set; }
        public DateTime StartTime { get; private set; }

        public List<Fisherman> competitors;

        private Guild guild;

        public Competition(Guild guild,String location, DateTime startTime)
        {
            this.guild = guild;
            this.Location = location;
            this.StartTime = startTime;
            this.competitors= new List<Fisherman>();
        }

        public void Register(Fisherman fisherman)
        {
            if (!guild.IsMember(fisherman))
            {
                throw new RegistrationException("Fisherman tries to register as non guild member");
            }
            competitors.Add(fisherman);
        }

        public double TotalValue()
        {
            double sum = 0.0;
            foreach(Fisherman fisherman in competitors)
            {
                sum += fisherman.TotalValue(this);
            }
            return sum;
        }

        public bool AllHasCatfish()
        {
            foreach(Fisherman fisherman in competitors)
            {
                if (!fisherman.HasCatfish(this))
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
