using CsharpExtensions.Tests.mocks;
using NUnit.Framework;

namespace CsharpExtensions.Tests
{
    [TestFixture, Parallelizable]
    public class GenericExtensionsTests
    {
        [Test, Parallelizable]
        public void IsNull_NotNullObject()
        {
            var testObj = new TestClass();
            Assert.IsFalse(testObj.IsNull());
        }

        [Test, Parallelizable]
        public void IsNull_NullObject()
        {
            TestClass testObj = null;
            Assert.IsTrue(testObj.IsNull());
        }

        [Test, Parallelizable]
        public void IsNull_NotNullStruct()
        {
            int? testObj = 15;
            Assert.IsFalse(testObj.IsNull());
        }

        [Test, Parallelizable]
        public void IsNull_NullStruct()
        {
            int? testObj = null;
            Assert.IsTrue(testObj.IsNull());
        }
    }
}
