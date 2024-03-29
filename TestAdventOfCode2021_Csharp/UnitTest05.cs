﻿using AdventOfCode2021_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestAdventOfCode2021Csharp
{
    [TestClass]
    public class UnitTest05
    {



        [TestClass()]
        public class ExcerciseTestsLines
        {

            [TestMethod()]
            public void Points()
            {
                Point test = new Point(47, 32);
                Assert.AreEqual(3192, test.GetHashCode());
            }


            Point start = new Point(4, 0);

            Point end = new Point(-1, 0);

            [TestMethod()]
            public void LineTest()
            {
                Line line = new Line(start, end);
                Assert.AreEqual(end, line.Start);
                Assert.AreEqual(start, line.End);
            }

            [TestMethod()]
            public void GetPointLineX2()
            {
                
                Line line = new Line(new Point(2,0), new Point(6,4));
                List<Point> pointsx = new List<Point>(){
               new Point(2, 0),new Point(3,1),new Point(4, 2),new Point(5, 3),new Point(6, 4)};
                CollectionAssert.AreEqual(pointsx, line.Points);
            }

            [TestMethod()]
            public void GetPointLineX()
            {
                List<Point> pointsx = new List<Point>(){
               new Point(-1, 0),new Point(0,0),new Point(1, 0),new Point(2, 0),new Point(3, 0),new Point(4, 0)
             };


                Line line = new Line(start, end);
                CollectionAssert.AreEqual(pointsx, line.Points);
            }

            [TestMethod()]
            public void GetPointLineY()
            {
                List<Point> pointsx = new List<Point>(){
               new Point(0, 0),new Point(0,1),new Point(0, 2)
             };


                Line line = new Line(new Point(0,0), new Point(0,2));
                CollectionAssert.AreEqual(pointsx, line.Points);
            }


            
            [DataRow(@"data/day5_part1_test.txt", 5)]
            [DataTestMethod]
            public void TestDay(string fileName, int expectedResult)
            {
                var fileContent = File.ReadAllText(fileName);
                var day = new Day5(fileContent);
                Assert.IsTrue(day.Load());
                //day.Part1();
                Assert.AreEqual(expectedResult, day.Part1());

            }

            [DataRow(@"data/day5_part1.txt", 5280)]
            [DataTestMethod]
            public void TestDay5_part1(string fileName, int expectedResult)
            {
                var fileContent = File.ReadAllText(fileName);
                var day = new Day5(fileContent);
                Assert.IsTrue(day.Load());
                //day.Part1();
                Assert.AreEqual(expectedResult, day.Part1());

            }

            [DataRow(@"data/day5_part1_test.txt", 12)]
            [DataTestMethod]
            public void TestDayPart2(string fileName, int expectedResult)
            {
                var fileContent = File.ReadAllText(fileName);
                var day = new Day5(fileContent);
                Assert.IsTrue(day.Load());
                //day.Part1();
                Assert.AreEqual(expectedResult, day.Part2());

            }

            [DataRow(@"data/day5_part1.txt", 16716)]
            [DataTestMethod]
            public void TestDay5_part2(string fileName, int expectedResult)
            {
                var fileContent = File.ReadAllText(fileName);
                var day = new Day5(fileContent);
                Assert.IsTrue(day.Load());
                //day.Part1();
                Assert.AreEqual(expectedResult, day.Part2());

            }

        }




    }
}