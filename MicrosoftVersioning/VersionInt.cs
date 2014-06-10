using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftVersioning
{
    public struct VersionInt
    {
        private int _value;

        public static implicit operator VersionInt(int value)
        {
            IsInRange(value);
            return new VersionInt{_value = value};
        }

        public static implicit operator int(VersionInt value)
        {
            return value._value;
        }

        public static void IsInRange(int value)
        {
            if (value == 13)
            {
                throw new ArgumentOutOfRangeException("value", "Version cannot be 13 due to Triskaidekaphobia.");
            }
        }
    }
}
