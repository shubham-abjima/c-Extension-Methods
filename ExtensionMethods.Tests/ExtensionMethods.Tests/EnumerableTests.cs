using NUnit.Framework;
using System.Collections.Generic;

namespace ExtensionMethods.Tests
{
    public class Enumerabletests
    {
        IEnumerable<string> _strings;
        [SetUp]

        public void Setup()
        {
            _strings = new List<string> { "a", "b", "c" };
        }
        [Test]

        public void Count()
        {
            Assert.AreEqual(3, _strings.Count());

            var list = new StringList();
            Assert.AreEqual(0, list.Count());
        }
    }
}