using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using CsharpExtension;
using System;

namespace CsharpExtensions.Tests
{
    [TestFixture]
    public class ListExtensionsTests
    {
        [Test]
        public void AreAllStringsEqualTestTrue()
        {
            new List<string> { "Test", "Test", "Test" }
            .AreAllEqual()
            .ShouldBeTrue();
        }

        [Test]
        public void AreAllStringsEqualTestFalse()
        {
            new List<string> { "Test2", "Test", "Test" }
            .AreAllEqual()
            .ShouldBeFalse();
        }

        [Test]
        public void Failed_AreAllEqualsTestOnNullList()
        {
            List<int> list = null;
            var exception = Should.Throw<ArgumentNullException>(() => list.AreAllEqual());
        }
    }
}
