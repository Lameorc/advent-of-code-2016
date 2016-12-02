using System;
using Advent_of_code.Day_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent_of_codeTests.Day_2
{
    [TestClass]
    public class KeypadPart2Tests
    {
        private KeypadPart2 keypad;
        [TestInitialize]
        public void Before()
        {
            keypad = new KeypadPart2();
        }
        [TestMethod()]
        public void SampleInputTest()
        {
            string input = "ULL\r\nRRDDD\r\nLURDL\r\nUUUUD";
            using (var sr = new System.IO.StringReader(input))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    keypad.ReadLine(line);
                }
            }
            Assert.AreEqual("5DB3", keypad.Output);
        }
    }
}
