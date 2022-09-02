namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public class SingleLinkedListNode<TNode>
    {
        public SingleLinkedListNode(TNode value)
        {
            Value = value;
            Next = null;
        }
        public TNode Value { get; set; }

        public SingleLinkedListNode<TNode>? Next { get; set; }

    }

}
