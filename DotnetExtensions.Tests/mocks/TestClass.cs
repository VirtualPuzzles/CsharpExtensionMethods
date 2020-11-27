using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExtensions.Tests.mocks
{
    internal class TestClass
    {
        public string StringValue { get; set; }
        public DateTime? DateValue { get; set; }
        public int? IntValue { get; set; }
    }

    internal class EquatableClass : IEquatable<EquatableClass>
    {
        public int ID { get; set; }
        public bool? Nullable { get; set; }

        public bool Equals(EquatableClass other)
        {
            if (other == null)
                return false;

            return ID == other.ID;
        }
    }
}
