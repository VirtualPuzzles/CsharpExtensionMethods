using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using CsharpExtension;

namespace CsharpExtensionsTests
{
    [TestFixture]
    public class ListExtensionsTests
    {
        [Test]
        public void AreAllStringsEqualTest()
        {
            new List<string> { "Test", "Test", "Test" }
            .AreAllEqual()
            .ShouldBeTrue();
        }

        [Test]
        public void AreAllStringsEqualTest_Failes()
        {
            new List<string> { "Test2", "Test", "Test" }
            .AreAllEqual()
            .ShouldBeFalse();
        }
    }
}
