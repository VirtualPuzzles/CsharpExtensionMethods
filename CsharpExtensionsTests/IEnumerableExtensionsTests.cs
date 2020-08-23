using System.Collections.Generic;
using Shouldly;
using CsharpExtension;
using System;
using System.Linq;
using NUnit.Framework;
using CsharpExtensions.Tests.mocks;

namespace CsharpExtensions.Tests
{
    [TestFixture]
    public class IEnumerableExtensionsTests
    {
        [Test]
        public void AreAllEqualTest_NullRefException()
        {
            Should.Throw<ArgumentNullException>(() => ((List<string>)null).AreAllEqual());
        }

        [Test]
        [TestCase(true, "Test", "Test", "Test")]
        [TestCase(false, "Test2", "Test", "Test")]
        [TestCase(false, null, "Test", "Test")]
        [TestCase(false, "Test", "Test", null)]
        [TestCase(false, "Test", "Test2", null)]
        [TestCase(true, null, null, null)]
        [TestCase(true, "Test")]
        public void AreAllEqualTest_string(bool expectation, params string[] values)
        {
            values?.AreAllEqual().ShouldBe(expectation);
        }

        [Test]
        [TestCase(true, 15, 15, 15)]
        [TestCase(false, 15, 15, 16)]
        [TestCase(true, 15)]
        public void AreAllEqualTest_int(bool expectation, params int[] values)
        {
            values.AreAllEqual().ShouldBe(expectation);
        }
        
        [Test]
        public void AreAllEqualTest_EqualClasses()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 }
            };

            list.AreAllEqual().ShouldBeTrue();
        }

        [Test]
        public void AreAllEqualTest_NotEqualClasses()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 }
            };

            list.AreAllEqual().ShouldBeFalse();
        }

        [Test]
        public void AreAllEqualTest_EqualClassesWithNull()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 },
                null
            };

            list.AreAllEqual().ShouldBeFalse();
        }

        [Test]
        public void AreAllEqualTest_NotEqualClassesWithNull()
        {
            var list = new List<EquatableClass>
            {
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 },
                null
            };

            list.AreAllEqual().ShouldBeFalse();
        }

        [Test]
        public void AreAllEqualTest_EqualClassesWithFirstItemNull()
        {
            var list = new List<EquatableClass>
            {
                null,
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 1 }
            };

            list.AreAllEqual().ShouldBeFalse();
        }

        [Test]
        public void AreAllEqualTest_NotEqualClassesWithFirstItemNull()
        {
            var list = new List<EquatableClass>
            {
                null,
                new EquatableClass { ID = 1 },
                new EquatableClass { ID = 2 }
            };

            list.AreAllEqual().ShouldBeFalse();
        }

    }
}
