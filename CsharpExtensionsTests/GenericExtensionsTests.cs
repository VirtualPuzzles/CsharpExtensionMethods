using CsharpExtensions.Tests.mocks;
using NUnit.Framework;
using Shouldly;

namespace CsharpExtensions.Tests
{
    [TestFixture, Parallelizable]
    public class GenericExtensionsTests
    {
        [Test, Parallelizable]
        public void IsNull_NotNullObject()
        {
            var testObj = new TestClass();
            testObj.IsNull().ShouldBeFalse();
        }

        [Test, Parallelizable]
        public void IsNull_NullObject()
        {
            TestClass testObj = null;
            testObj.IsNull().ShouldBeTrue();
        }

        [Test, Parallelizable]
        public void IsNull_NotNullStruct()
        {
            int? testObj = 15;
            testObj.IsNull().ShouldBeFalse();
        }

        [Test, Parallelizable]
        public void IsNull_NullStruct()
        {
            int? testObj = null;
            testObj.IsNull().ShouldBeTrue();
        }
    }
}
