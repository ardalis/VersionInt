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
            return new VersionInt{_value = value};
        }

        public static implicit operator int(VersionInt value)
        {
            return value._value;
        }
    }
}
