using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_of_code.Day_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_2.Tests
{
    [TestClass()]
    public class KeypadTests
    {
        private Keypad keypad;

        [TestInitialize]
        public void Before()
        {
            keypad = new Keypad();
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
            Assert.AreEqual("1985", keypad.Output);
        }

       
    }
}