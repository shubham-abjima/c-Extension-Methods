using System.Collections.Generic;
namespace ExtensionMethod.Tests
{
    public class EnumerableTests
    {
        IEnumerable<string> _strings;

        [SetUp]

        public void Setup()
        {
            _strings = new List<string> { "a","b","c"};
        }
        [Test]
        public void Count()
        {
            Assert.AreEqual(3,_strings.Count());
        }

    }
}