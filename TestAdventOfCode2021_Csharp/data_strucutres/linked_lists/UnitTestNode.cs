using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2021_CSharp.data_structures.linked_lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAdventOfCode2021_Csharp.data_strucutres.linked_lists
{
    [TestClass]
    public class UnitTestNode
    {
          
        [TestMethod]
        public void NewSingleNodeTest() 
        {
            var tmp = new SingleLinkedListNode<int>(1);

            Assert.IsNull(tmp.Next);
            Assert.AreEqual(1, tmp.Value);
        }

        [TestMethod]
        public void NewSDoubleNodeTest()
        {
            var tmp = new DoublyLinkedListNode<int>(1);

            Assert.IsNull(tmp.Next);
            Assert.IsNull(tmp.Previous);
            Assert.AreEqual(1, tmp.Value);
        }
    }
}
