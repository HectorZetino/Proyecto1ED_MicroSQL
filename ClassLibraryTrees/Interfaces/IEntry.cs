using ClassLibraryTrees.B_Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTrees.Interfaces
{
    public interface IEntry<TKey, T>
    {
        bool Equals(Entry<TKey, T> other);
    }
}
