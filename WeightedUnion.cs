using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
   public class WeightedUnion
    {
        private int[] id; // parent link (site indexed)
        private int[] sz; // size of component for roots (site indexed)
        private int _count; // number of components
        public WeightedUnion(int N)
        {
            _count = N;
            id = new int[N];
            id = new int[N];
            for (int i = 0; i < N; i++) id[i] = i;
            sz = new int[N];
            for (int i = 0; i < N; i++) sz[i] = 1;
        }
        
        public int Count()
        { return _count; }
       
        public bool Connected(int p, int q)
        { return find(p) == find(q); }
        
        private int find(int p)
        { // Follow links to find a root.
            while (p != id[p]) p = id[p];
            return p;
        }


        public override String ToString()
        {
            string result = " ";
            for (int i = 0; i < id.Length; i++)
            {
                result += id[i] + " ";
            }

            return result;
        }

        public void union(int p, int q)
        {
            int i = find(p);
            int j = find(q);
            if (i == j) return;
            // Make smaller root point to larger one.
            if (sz[i] < sz[j]) { id[i] = j; sz[j] += sz[i]; }
            else { id[j] = i; sz[i] += sz[j]; }
            _count--;
        }
    }
}
