using NUnit.Framework;
using LMS1XX;
using System;

namespace PF_InterfaceTests {
    [TestFixture]
    public class LMS1XXTest {
        private LMS1XX.LMS1XX _lms1xx;

        [SetUp]
        public void SetUp() {
            _lms1xx = new LMS1XX.LMS1XX("192.168.0.85", 2112, 5, 5);
        }

        [Test]
        public void IsSocketConnected() {
            var result = _lms1xx.Connect();

            Assert.AreEqual(LMS1XX.LMS1XX.SocketConnectionResult.CONNECTED, result, "lms can't connect");
        }
    }
}