using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAdventOfCode2021Csharp
{
    [TestClass]
    public class UnitTest06
    {

        //[DataRow(@"data/day6_test.txt", 26, 18)]
        [DataRow(@"data/day6_test1.txt", 26, 18)]
        [DataRow(@"data/day6_test1.txt", 5934, 80)]
        [DataTestMethod]
        public void TestDay6(string fileName, int fishes, int days)
        {
            var fileContent = File.ReadAllText(fileName);
            var day6 = new Day6(fileContent);
            Assert.IsTrue(day6.Load());
            Assert.AreEqual(fishes, day6.Part1Niave(days));

        }

        [DataRow(@"data/day6_1.txt", 386640, 80)]
        [DataTestMethod]
        public void TestDay6Part1(string fileName, int fishes, int days)
        {
            var fileContent = File.ReadAllText(fileName);
            var day6 = new Day6(fileContent);
            Assert.IsTrue(day6.Load());
            Assert.AreEqual(fishes, day6.Part1Niave(days));

        }

        [DataRow(@"data/day6_test2.txt", 5, 18)]
        [DataTestMethod]
        public void TestDay6PartSmall(string fileName, int fishes, int days)
        {
            var fileContent = File.ReadAllText(fileName);
            var day6 = new Day6(fileContent);
            Assert.IsTrue(day6.Load());
            Assert.AreEqual(fishes, day6.Part1Niave(days));

        }

        [DataRow(@"data/day6_test1.txt", 26, 18)]
        [DataRow(@"data/day6_test1.txt", 5934, 80)]
        [DataTestMethod]
        public void TestDay6Part2(string fileName, int fishes, int days)
        {
            var fileContent = File.ReadAllText(fileName);
            var day6 = new Day6(fileContent);
            Assert.IsTrue(day6.Load());
            Assert.AreEqual(fishes, day6.Part1Niave(days));
            Assert.AreEqual(fishes, day6.PartOptimzaded(days));

        }
    }
}
