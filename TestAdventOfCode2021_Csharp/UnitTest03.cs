using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest03
    {

        [DataRow(@"data/day3_part1_test.txt", 9, 22, 198)]
        [DataTestMethod]
        public void TestDay3(string fileName, int expectedRate, int gammaRate, int consumption)
        {
            var fileContent = File.ReadAllText(fileName);
            var day1 = new Day3(fileContent);
            Assert.IsTrue(day1.Load());

        }
        [TestMethod]
        public void TestBinaryToDecimal( )
        {
            Assert.AreEqual(22.0, Day3.BinaryToDecimal("10110"));
        }


        [TestClass()]
        public class ExcerciseTests
        {
            private List<string> data = new List<string>()
        {"01110", "11111", "00000"};
            int position = 2;
            private List<string> expected = new List<string>()
        {"01110", "11111"};

            [TestMethod()]
            public void TheLeastCommonTest()
            {
                Day3 test = new Day3(data);
                List<string> res = test.TheLeastCommon(data, position);
                CollectionAssert.AreEqual(expected, res);
            }
        }



    }
}