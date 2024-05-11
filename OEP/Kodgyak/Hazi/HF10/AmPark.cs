using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF10
{
    public class AmPark
    {
        private HashSet<Guest> guests;
        private List<TargetShot> targetShots;

        public AmPark(List<TargetShot> t)
        {
            if (t.Count < 2)
            {
                throw new ArgumentException("Too few target shots");
            }

            targetShots = t;
            guests = new HashSet<Guest>();
        }

        public string? Best(TargetShot t)
        {
            if (guests.Count == 0)
            {
                throw new Exception("There isn't any previous guests who had tried the target shots");
            }

            var bestGuest = guests.OrderByDescending(g => g.Result(t)).FirstOrDefault();

            return bestGuest != null ? bestGuest.getName() : null;
        }

        public void Receives(Guest g)
        {
            if (guests.Contains(g))
            {
                throw new ArgumentException("This guest is already inside the amusement park");
            }
            guests.Add(g);
        }

    }
}
