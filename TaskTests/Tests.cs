using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using ds.test.impl;

namespace TaskTests
{
    [TestFixture]
    public class Tests
    {
        private Plugins pluginFactory;
        private IPlugin adding;
        private IPlugin subtracting;
        
        [SetUp]
        public void InitTests()
        {
            pluginFactory = new Plugins();
            adding = pluginFactory.GetPlugin("Addition");
            subtracting = pluginFactory.GetPlugin("Subtraction");
        }
        
        [Test]
        public void TestGetPlugin()
        {
            Assert.IsInstanceOf(typeof(IPlugin), adding);
            Assert.IsInstanceOf(typeof(IPlugin), subtracting);
            Assert.Throws<Exception>(() => pluginFactory.GetPlugin("The wrong name"));
        }
        
        [Test]
        public void TestAddition()
        {
            Assert.AreEqual(adding.Run(5, 8), 5 + 8);
            Assert.Throws<OverflowException>(() => adding.Run(int.MaxValue, 1));
        }
        [Test]
        public void TestSubtraction()
        {
            Assert.AreEqual(subtracting.Run(5, 8), 5 - 8);
            Assert.Throws<OverflowException>(() => subtracting.Run(int.MinValue, 1));
        }
    }
}