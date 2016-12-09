using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_of_code.Day_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Day_7.Tests
{
    [TestClass()]
    public class IpAdressTests
    {
        private string[] _sampleInputs;
        private string[] _sampleSslInputs;
        private IpAdress _adress;
        [TestInitialize]
        public void Init()
        {
            _sampleInputs = new[]
            {
                "abba[mnop]qrst",
                "abcd[bddb]xyyx",
                "aaaa[qwer]tyui",
                "ioxxoj[asdfgh]zxcvbn",
            };
            _sampleSslInputs = new[]
            {
                "aba[bab]xyz",
                "xyx[xyx]xyx",
                "aaa[kek]eke",
                "zazbz[bzb]cdb",
            };

            _adress = new IpAdress("");
        }

        [TestMethod()]
        public void IsTlsCapableTest1()
        {
            _adress.Address = _sampleInputs[0];
            Assert.IsTrue(_adress.IsTlsCapable());
        }

        [TestMethod()]
        public void IsTlsCapableTest2()
        {
            _adress.Address = _sampleInputs[1];
            Assert.IsFalse(_adress.IsTlsCapable());
        }

        [TestMethod()]
        public void IsTlsCapableTest3()
        {
            _adress.Address = _sampleInputs[2];
            Assert.IsFalse(_adress.IsTlsCapable());

        }

        [TestMethod()]
        public void IsTlsCapableTest4()
        {
            _adress.Address = _sampleInputs[3];
            Assert.IsTrue(_adress.IsTlsCapable());
        }

        [TestMethod()]
        public void IsSslCapableTest1()
        {
            _adress.Address = _sampleSslInputs[0];
            Assert.IsTrue(_adress.IsSslCapable());
        }
        [TestMethod()]
        public void IsSslCapableTest2()
        {
            _adress.Address = _sampleSslInputs[1];
            Assert.IsFalse(_adress.IsSslCapable());
        }
        [TestMethod()]
        public void IsSslCapableTest3()
        {
            _adress.Address = _sampleSslInputs[2];
            Assert.IsTrue(_adress.IsSslCapable());
        }
        [TestMethod()]
        public void IsSslCapableTest4()
        {
            _adress.Address = _sampleSslInputs[3];
            Assert.IsTrue(_adress.IsSslCapable());
        }
    }
}