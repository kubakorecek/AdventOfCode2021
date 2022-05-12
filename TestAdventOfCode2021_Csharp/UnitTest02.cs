using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest02
    {

        [DataRow(@"data/day2_part1_test.txt", 15, 10, 150, 900)]
        [DataTestMethod]
        public void TestDay2(string fileName,int horizontalPositionExpeceted, int aimExcpected, int part1, int part2)
        {
            var fileContent = File.ReadAllText(fileName);
            var day2 = new Day2(fileContent);
            Assert.IsTrue(day2.Load());
            Assert.IsTrue(day2.Calculate());
            Assert.AreEqual(horizontalPositionExpeceted, day2.Result.HorizontalPositionl);
            Assert.AreEqual(aimExcpected, day2.Result.Aim);
             Assert.AreEqual(part1, day2.Part1());
             Assert.AreEqual(part2, day2.Part2());

        }


        [DataRow(@"data/day2.txt", 2147104, 2044620088)]
        [DataTestMethod]
        public void TestDay2Res(string fileName, int part1, int part2)
        {
            var fileContent = File.ReadAllText(fileName);
            var day2 = new Day2(fileContent);
            Assert.IsTrue(day2.Load());
            day2.Calculate();
            Assert.AreEqual(part1, day2.Part1());
            Assert.AreEqual(part2, day2.Part2());

        }





    }
}