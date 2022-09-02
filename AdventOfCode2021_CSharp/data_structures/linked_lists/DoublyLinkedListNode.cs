using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public class DoublyLinkedListNode<TNode>
    {
        public DoublyLinkedListNode(TNode value)
        {
            Value = value;
            Previous = null;
            Next = null;
        }
        public TNode Value { get; set; }

        public DoublyLinkedListNode<TNode>? Previous { get; set; }

        public DoublyLinkedListNode<TNode>? Next { get; set; }

    }

}
