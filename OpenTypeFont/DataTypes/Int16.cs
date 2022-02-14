using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int16
    {
        private readonly short _value;
        public readonly short Value => _value;
        public Int16(short value) => _value = value;
        public static explicit operator Int16(short v)
        {
            return new Int16(v);
        }
        public static F2DOT14 operator /(Int16 v1, Int16 v2)
        {
            return new F2DOT14(v1.Value / v2.Value);
        }
    }
}
