using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHelm_sDeep
{
    public class UniqueList<T> : IEnumerable<T>
    {
        private List<T> list = new List<T>();
        private HashSet<T> set = new HashSet<T>();

        public bool Add(T item)
        {
            if (set.Add(item))
            {
                list.Add(item);
                return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
            if (set.Remove(item))
            {
                list.Remove(item);
                return true;
            }
            return false;
        }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
