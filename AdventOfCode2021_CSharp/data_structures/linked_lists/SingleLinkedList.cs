using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public class SingleLinkedList<T> : LinkedList<T>, ICollection<T>
    {
        SingleLinkedListNode<T> head = null;

        SingleLinkedListNode<T> tail = null;





        #region Add
        protected override void AddHead(T value)
        {
            SingleLinkedListNode < T > node = new SingleLinkedListNode<T>(value);

            if ( head == null) 
            {
                head = node;
                tail = node;
            } else 
            {
                node.Next = head;
                head = node;
            }
        }

        public void Add(T item)
        {
            AddHead(item);
        }

        #endregion
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();




        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
