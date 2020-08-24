using NUnit.Framework;
using Shouldly;

namespace CsharpExtensions.Tests
{
    [TestFixture, Parallelizable]
    public class StringExtensionsTests
    {
        [Test, Parallelizable]
        [TestCase(true, "")]
        [TestCase(true, " ")]
        [TestCase(false, "Test")]
        [TestCase(true, null)]
        public void IsNullOrWhiteSpaceTest(bool expectation, string s)
        {
            s.IsNullOrWhiteSpace().ShouldBe(expectation);
        }

        [Test, Parallelizable]
        [TestCase(true, "")]
        [TestCase(false, " ")]
        [TestCase(false, "Test")]
        [TestCase(true, null)]
        public void IsNullOrEmptyTestOnEmpty(bool expectation, string s)
        {
            s.IsNullOrEmpty().ShouldBe(expectation);
        }
    }
}
