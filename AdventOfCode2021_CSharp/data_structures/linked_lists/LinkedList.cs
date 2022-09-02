using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public abstract class LinkedList<T>
    {
        protected abstract void AddHead(T value);

    }
}
