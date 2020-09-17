using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using ds.test.impl;

namespace TaskTests
{
    [TestFixture]
    public class Tests
    {
        private Plugins _pluginFactory;
        private IPlugin _adding;
        private IPlugin _subtracting;
        
        [SetUp]
        public void InitTests()
        {
            _pluginFactory = new Plugins();
            _adding = _pluginFactory.GetPlugin("Addition");
            _subtracting = _pluginFactory.GetPlugin("Subtraction");
        }
        
        [Test]
        public void TestGetPlugin()
        {
            Assert.IsInstanceOf(typeof(IPlugin), _adding);
            Assert.IsInstanceOf(typeof(IPlugin), _subtracting);
            Assert.Throws<Exception>(() => _pluginFactory.GetPlugin("The wrong name"));
        }
        
        [Test]
        public void TestAddition()
        {
            Assert.AreEqual(_adding.Run(5, 8), 5 + 8);
            Assert.Throws<OverflowException>(() => _adding.Run(int.MaxValue, 1));
        }
        [Test]
        public void TestSubtraction()
        {
            Assert.AreEqual(_subtracting.Run(5, 8), 5 - 8);
            Assert.Throws<OverflowException>(() => _subtracting.Run(int.MinValue, 1));
        }
    }
}