using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class QuickUnion : IUnionFind
    {
        private int[] _parrent;
        private int _count;
        

        public QuickUnion(int n)
        {
            _parrent = new int[n];

            for (int i = 0; i < n; i++)
            {
                _parrent[i] = i;
            }
        }



        public int Find(int p)
        {
            Validate(p);

            while (p != _parrent[p])
                p = _parrent[p];
            return p;
        }

        public void Validate(int p)
        {
            int n = _parrent.Length;

            if (p < 0 || p >= n)
            {
                throw new ArgumentException("index" + p + "is not between 0 and" + (n - 1));
            }

        }

        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }


        public override String ToString()
        {
            string result = " ";
            for (int i = 0; i< _parrent.Length; i++) {
                result+=_parrent[i] + " ";
            }

            return result;
        }


        int IUnionFind.Count()
        {
            return _count;
        }

        public void Union(int p, int q)
        {
            int pRoot = Find(p);

            int qRoot = Find(q);
            if (pRoot == qRoot) return;
            _parrent[pRoot] = qRoot;
            _count--;
        }
    }
}
