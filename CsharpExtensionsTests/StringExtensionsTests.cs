using System;
using NUnit.Framework;
using Shouldly;
using CsharpExtension;

namespace CsharpExtensions.Tests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void IsNullOrWhiteSpaceTestOnEmpty()
        {
            "".IsNullOrWhiteSpace().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnSpace()
        {
            " ".IsNullOrWhiteSpace().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnWord()
        {
            "Test".IsNullOrWhiteSpace().ShouldBeFalse();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnNull()
        {
            ((string)null).IsNullOrWhiteSpace().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrEmptyTestOnEmpty()
        {
            "".IsNullOrEmpty().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrEmptyTestOnSpace()
        {
            " ".IsNullOrEmpty().ShouldBeFalse();
        }

        [Test]
        public void IsNullOrEmptyTestOnWord()
        {
            "Test".IsNullOrEmpty().ShouldBeFalse();
        }

        [Test]
        public void IsNullOrEmptyTestOnNull()
        {
            ((string)null).IsNullOrWhiteSpace().ShouldBeTrue();
        }
    }
}
