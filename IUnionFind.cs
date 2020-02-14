using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    interface IUnionFind
    {
        void Union(int p, int q);
        int Find(int p);
        bool Connected(int p, int q);
        int Count();
    }
}
