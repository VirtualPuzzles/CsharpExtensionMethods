using System.Collections.Generic;
using System;
using NUnit.Framework;
using DotnetExtensions.Tests.mocks;

namespace DotnetExtensions.Tests
{
    [TestFixture, Parallelizable]
    public class IEnumerableExtensionsTests
    {
        [Test, Parallelizable]
        public void AreAllEqualTest_NullRefException()
        {
            Assert.Throws<ArgumentNullException>(() => ((List<string>)null).AreAllEqual());
        }

        [Test, Parallelizable]
        [TestCase(true, "Test", "Test", "Test")]
        [TestCase(false, "Test2", "Test", "Test")]
        [TestCase(false, null, "Test", "Test")]
        [TestCase(false, "Test", "Test", null)]
        [TestCase(false, "Test", "Test2", null)]
        [TestCase(true, null, null, null)]
        [TestCase(true, "Test")]
        public void AreAllEqualTest_string(bool expectation, params string[] values)
        {
            Assert.AreEqual(values?.AreAllEqual(), expectation);
        }

        [Test, Parallelizable]
        [TestCase(true, 15, 15, 15)]
        [TestCase(false, 15, 15, 16)]
        [TestCase(true, 15)]
        public void AreAllEqualTest_int(bool expectation, params int[] values)
        {
            Assert.AreEqual(values.AreAllEqual(), expectation);
        }
        
        [Test, Parallelizable]
        public void AreAllEqualTest_EqualClasses()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 }
            };

            Assert.IsTrue(list.AreAllEqual());
        }

        [Test, Parallelizable]
        public void AreAllEqualTest_NotEqualClasses()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 }
            };

            Assert.IsFalse(list.AreAllEqual());
        }

        [Test, Parallelizable]
        public void AreAllEqualTest_EqualClassesWithNull()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 },
                null
            };

            Assert.IsFalse(list.AreAllEqual());
        }

        [Test, Parallelizable]
        public void AreAllEqualTest_NotEqualClassesWithNull()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 },
                null
            };

            Assert.IsFalse(list.AreAllEqual());
        }

        [Test, Parallelizable]
        public void AreAllEqualTest_EqualClassesWithFirstItemNull()
        {
            var list = new List<EquatableClass>
            {
                null,
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 }
            };

            Assert.IsFalse(list.AreAllEqual());
        }

        [Test, Parallelizable]
        public void AreAllEqualTest_NotEqualClassesWithFirstItemNull()
        {
            var list = new List<EquatableClass>
            {
                null,
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 }
            };

            if (list[0]?.Nullable ?? false)

            Assert.IsFalse(list.AreAllEqual());
        }

    }
}
