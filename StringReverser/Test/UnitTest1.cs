using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReverser;

namespace Test
{
    [TestClass]
    public class StringReverserTest
    {
        string robert = "Robert Baratheon";
        string jon = "Jon Snow";

        [TestInitialize]
        public void Setup()
        {
            robert = "Robert Baratheon";
            jon = "Jon Snow";
        }

        [TestMethod]
        public void DefaultStringReverserReversesString()
        {
            Assert.AreEqual("noehtaraB treboR", StringHelper.Reverse(robert));
            Assert.AreEqual("wonS noJ", StringHelper.Reverse(jon));
        }

        [TestMethod]
        public void ArrayStringReverserReversesString()
        {
            Assert.AreEqual("noehtaraB treboR", StringHelper.ReverseUsingArrayReverse(robert));
            Assert.AreEqual("wonS noJ", StringHelper.ReverseUsingArrayReverse(jon));
        }
    }
}
