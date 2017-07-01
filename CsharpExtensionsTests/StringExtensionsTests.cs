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
            "".IsNullORWhiteSpace().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnSpace()
        {
            " ".IsNullORWhiteSpace().ShouldBeTrue();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnWord()
        {
            "Test".IsNullORWhiteSpace().ShouldBeFalse();
        }

        [Test]
        public void IsNullOrWhiteSpaceTestOnNull()
        {
            ((string)null).IsNullORWhiteSpace().ShouldBeTrue();
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
            ((string)null).IsNullORWhiteSpace().ShouldBeTrue();
        }
    }
}
