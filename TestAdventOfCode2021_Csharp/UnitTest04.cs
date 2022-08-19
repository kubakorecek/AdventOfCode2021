using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021_Csharp
{
    [TestClass]
    public class UnitTest04
    {
        [DataRow(@"data/data04_test.txt", 4512)]
        [DataRow(@"data/day04Part1.txt", 28082)]
        [DataTestMethod]
        public void TestDay4(string fileName,int expectedResult)
        {
            var fileContent = File.ReadAllText(fileName);
            var day4 = new Day4(fileContent);

            var success = day4.Load();
            Assert.IsTrue(success);

            Assert.AreEqual(expectedResult, day4.PartOne());


        }

        [DataRow(@"data/data04_test.txt", 4512)]
        [DataRow(@"data/day04Part1.txt", 28082)]
        [DataTestMethod]
        public void TestDay4P2(string fileName, int expectedResult)
        {
            var fileContent = File.ReadAllText(fileName);
            var day4 = new Day4(fileContent);

            var success = day4.Load();
            Assert.IsTrue(success);

            Assert.AreEqual(expectedResult, day4.PartTwo());


        }



        [DataRow(@"data/board04_test.txt")]
        [DataTestMethod]
        public void TestBoard(string fileName)
        {
            var fileContent = File.ReadAllText(fileName);
            var board = new Board(fileContent);
            int element = 22;
            //var winner = board.CheckWin();
            var success = board.RemoveElement(element);
            Assert.IsTrue(success);
            element = -22;
            success = board.RemoveElement(element);
            Assert.IsFalse(success);

            var row = new List<int> { 17, 13, 0, 11 };
            Assert.IsFalse(board.IsWinner());

            row.ForEach(element => board.RemoveElement(element));

            Assert.IsTrue(board.IsWinner());
            Assert.AreEqual(237,board.Sum() );


        }

    }
}