using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3.Tests
{
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
            Excercise test = new Excercise(filePath:"");
            List<string> res = test.theLeastCommon(data, position);
            CollectionAssert.AreEqual(expected, res);
        }
    }
}