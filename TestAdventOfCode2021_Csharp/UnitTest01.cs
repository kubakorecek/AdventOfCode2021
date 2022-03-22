using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest01
    {

        [DataRow(@"data/day1_test.txt", 7, 5)]
        [DataRow(@"data/day1.txt", 1298, 1248)]
        [DataTestMethod]
        public void TestDay1(string fileName,int expectedResult, int expectedResult2)
        {
            var fileContent = File.ReadAllText(fileName);
            var day1 = new Day1(fileContent);
            Assert.IsTrue(day1.Load());
            Assert.AreEqual(expectedResult, day1.Part1());
            Assert.AreEqual(expectedResult2, day1.Part2());

        }

        [DataRow(@"data/day1_test.txt",7)]
        public void TestDay1_b(string fileName, int expectedResult)
        {
            var fileContent = File.ReadAllText(fileName);
            var day1 = new Day1(fileContent);
            Assert.IsTrue(day1.Load());

             List<int> expectedList = new List<int> {
               199,200,208,210,200,207,240,269,260,263
             };
             CollectionAssert.AreEqual(expectedList, day1.Numbers);
            
            Assert.AreEqual(expectedResult, day1.Part1());

        }





    }
}