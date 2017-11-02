using CsharpExtensions.Tests.mocks;
using NUnit.Framework;
using Shouldly;

namespace CsharpExtensions.Tests
{
    [TestFixture]
    public class GenericExtensionsTests
    {
        [Test]
        public void IsObjectNullTestWithNotNullObject()
        {
            var testObj = new TestClass();
            testObj.IsNull().ShouldBeFalse();
        }

        [Test]
        public void IsObjectNullTestWithNullObject()
        {
            TestClass testObj = null;
            testObj.IsNull().ShouldBeTrue();
        }

        [Test]
        public void IsObjectNullTestWithUnsetObject()
        {
            TestClass testObj = null;
            testObj.IsNull().ShouldBeTrue();
        }
    }
}
