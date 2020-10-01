using NUnit.Framework;

namespace CsharpExtensions.Tests
{
    [TestFixture, Parallelizable]
    public class StringExtensionsTest
    {
        [Test, Parallelizable]
        [TestCase(true, "")]
        [TestCase(true, " ")]
        [TestCase(false, "Test")]
        [TestCase(true, null)]
        public void IsNullOrWhiteSpaceTest(bool expectation, string s)
        {
            Assert.AreEqual(s.IsNullOrWhiteSpace(), expectation);
        }

        [Test, Parallelizable]
        [TestCase(true, "")]
        [TestCase(false, " ")]
        [TestCase(false, "Test")]
        [TestCase(true, null)]
        public void IsNullOrEmptyTestOnEmpty(bool expectation, string s)
        {
            Assert.AreEqual(s.IsNullOrEmpty(), expectation);
        }
    }
}
