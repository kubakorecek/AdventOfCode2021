using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using static AdventOfCode2021_CSharp.Day3;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest03
    {

        [DataRow(@"data/day3_part1_test.txt", 9, 22, 198)]
        [DataTestMethod]
        public void TestDay3TestData(string fileName, int expectedRate, int gammaRate, int consumption)
        {
            var fileContent = File.ReadAllText(fileName);
            var day3 = new Day3(fileContent);
            Assert.IsTrue(day3.Load());

            SubmarineData reusult = day3.Consumptions();

            Assert.AreEqual(gammaRate, reusult.gammaRate);
            Assert.AreEqual(expectedRate, reusult.epsilonRate);
            Assert.AreEqual(consumption, reusult.consumption);
        }

        [DataRow(@"data/day3_part1.txt", 1131506)]
        [DataTestMethod]
        public void TestDay3(string fileName, int consumption)
        {
            var fileContent = File.ReadAllText(fileName);
            var day3 = new Day3(fileContent);
            Assert.IsTrue(day3.Load());

            SubmarineData reusult = day3.Consumptions();
            Assert.AreEqual(consumption, reusult.consumption);
            Assert.AreEqual(3797, reusult.gammaRate);
            Assert.AreEqual(298, reusult.epsilonRate);
            
        }



        [TestMethod]
        public void TestBinaryToDecimal()
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