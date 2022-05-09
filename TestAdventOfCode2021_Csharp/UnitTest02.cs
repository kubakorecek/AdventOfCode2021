using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest02
    {

        [DataRow(@"data/day2_part1_test", 10, 15, 150)]
        [DataTestMethod]
        public void TestDay1(string fileName,int horizontalPositionExpeceted, int depthExpeceted)
        {
            var fileContent = File.ReadAllText(fileName);
            var day2 = new Day2(fileContent);
            Assert.IsTrue(day2.Load());
            /*Assert.AreEqual(horizontalPositionExpeceted, day1.Part1());
            Assert.AreEqual(horizontalPositionExpeceted, day1.Part2());
            Assert.AreEqual(horizontalPositionExpeceted, day1.Part2());*/

        }


        





    }
}