using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_of_code.Day_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_4.Tests
{
    [TestClass()]
    public class RoomTests
    {
        private string[] _testInputs;

        [TestInitialize]
        public void Init()
        {
            _testInputs = new string[]{
                "aaaaa-bbb-z-y-x-123[abxyz]",
                "a-b-c-d-e-f-g-h-987[abcde]",
                "not-a-real-room-404[oarel]",
                "totally-real-room-200[decoy]",
                "qzmt-zixmtkozy-ivhz-343[dunno]"
            };
       
        }

        [TestMethod()]
        public void IsRealTestString1()
        {
            var room = new Room(_testInputs[0]);
            Assert.IsTrue(room.IsReal());
        }
        [TestMethod()]
        public void IsRealTestString2()
        {
            var room = new Room(_testInputs[1]);
            Assert.IsTrue(room.IsReal());
        }
        [TestMethod()]
        public void IsRealTestString3()
        {
            var room = new Room(_testInputs[2]);
            Assert.IsTrue(room.IsReal());
        }
        [TestMethod()]
        public void IsRealTestString4()
        {
            var room = new Room(_testInputs[3]);
            Assert.IsFalse(room.IsReal());
        }

        [TestMethod]
        public void DecryptTest()
        {
            var room = new Room(_testInputs[4]);
            Assert.AreEqual("very encrypted name", room.DecryptName());
        }
    }
}