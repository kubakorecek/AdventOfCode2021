using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public abstract class LinkedList<TNode>  
        where TNode : class
    {

        protected TNode? head { get; set; } = null;

        protected TNode? tail { get; set; } = null;
        protected abstract void AddHead(TNode value);

        protected abstract void AddTail(TNode value);

    }
}
