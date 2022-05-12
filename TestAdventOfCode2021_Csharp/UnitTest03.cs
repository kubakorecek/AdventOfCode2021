using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest03
    {

        [DataRow(@"data/day3_test.txt", 9, 22, 198)]
        [DataTestMethod]
        public void TestDay1(string fileName, int expectedRate, int gammaRate, int consumption)
        {
            var fileContent = File.ReadAllText(fileName);
            var day1 = new Day1(fileContent);
            Assert.IsTrue(day1.Load());

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
            public void theLeastCommonTest()
            {
                Day3 test = new Day3(data);
                List<string> res = test.theLeastCommon(data, position);
                CollectionAssert.AreEqual(expected, res);
            }
        }



    }
}