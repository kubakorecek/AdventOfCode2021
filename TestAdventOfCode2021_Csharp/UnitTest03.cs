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
        public void TestDay1(string fileName,int expectedRate, int gammaRate, int consumption)
        {
            var fileContent = File.ReadAllText(fileName);
            var day1 = new Day1(fileContent);
            Assert.IsTrue(day1.Load());

        }






    }
}