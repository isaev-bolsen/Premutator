using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    public class Premutator
    {
        private SortedSet<string> collected = new SortedSet<string>();

        public Premutator(string original)
        {
            Premutate(original, 0);
        }

        private void Premutate(string original, int k)
        {
            for (int i = k; i < original.Length; ++i)
            {
                string cur = Swap(original, i, k);
                collected.Add(cur);
                Premutate(cur, k + 1);
            }
        }

        private string Swap(string s, int i, int k)
        {
            var a = s.ToArray();
            char buf = a[i];
            a[i] = a[k];
            a[k] = buf;
            return new string(a);
        }

        public List<string> GetCollected()
        {
            return collected.ToList();
        }
    }
}
