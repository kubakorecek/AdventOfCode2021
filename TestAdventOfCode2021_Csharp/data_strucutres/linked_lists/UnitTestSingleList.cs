using AdventOfCode2021_CSharp.data_structures.linked_lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventOfCode2021_Csharp.data_strucutres.linked_lists
{
    [TestClass]
    public class SingleListTest
    {
        [TestMethod]
        public void TestAdd() 
        {
            var node1 = new SingleLinkedListNode<int>(1);
            var node2 = new SingleLinkedListNode<int>(2);
            var node3 = new SingleLinkedListNode<int>(3);
            var node4 = new SingleLinkedListNode<int>(4);

            var list = new SingleLinkedList<SingleLinkedListNode<int>>(); 

            list.Add(node1);
            Assert.IsNotNull(list.Head);
            Assert.IsNotNull(list.Tail);
            Assert.AreEqual(1 , list.Head);
            list.Add(node2);

            list.Add(node3);

            list.Add(node4);
        }
    }
}
