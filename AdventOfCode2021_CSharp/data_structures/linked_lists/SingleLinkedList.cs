using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventOfCode2021_CSharp.data_structures.linked_lists
{
    public class SingleLinkedList<T> : LinkedList< SingleLinkedListNode<T>>, ICollection<T>
    {
        public T? Head => head!.Value;

        public T? Tail
        {
            get => tail!.Value;
        }

        #region Add
        protected void AddHead(T value)
        {
            AddHead(new SingleLinkedListNode<T>(value));
        }

        protected override void AddHead(SingleLinkedListNode<T> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
        }

        public void Add(T item)
        {
            AddHead(item);
        }

        public void Add(SingleLinkedListNode<T> node)
        {
            AddHead(node);
        }

        public void AddTail(T value)
        {
            AddTail(new SingleLinkedListNode<T>(value)); 
        }

        protected override void AddTail(SingleLinkedListNode<T> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node = tail;
            }
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
