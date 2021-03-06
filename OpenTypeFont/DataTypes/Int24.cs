using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int24
    {
        private readonly int _value;
        public readonly int Value => _value;
        public Int24(int value) => _value = value;

        public static explicit operator Int24(int v)
        {
            if (v > 8388607 || v < -8388608)
                throw new ArgumentOutOfRangeException(nameof(v));
            // this will trim the first high-order bits from the uint
            return new Int24(v & 0xFFFFFF);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
