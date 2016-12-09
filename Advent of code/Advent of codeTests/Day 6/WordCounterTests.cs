using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_of_code.Day_6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_6.Tests
{
    [TestClass()]
    public class WordCounterTests
    {
        private WordCounter wc = new WordCounter();
        [TestInitialize]
        public void Init()
        {
            wc.ReadWords(@"E:\Data\coding\Various\Advent of code 2016\Advent of code\Advent of codeTests\Day 6\sampleInput.txt");
        }

        [TestMethod]
        public void GetRealMessageTestPart1()
        {
            Assert.AreEqual("easter", wc.GetRealMessagePart1());
        }

        [TestMethod]
        public void GetRealMessageTestPart2()
        {
            Assert.AreEqual("advent", wc.GetRealMessagePart2());
        }
    }
}