using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int32
    {
        private readonly int _value;
        public readonly int Value => _value;
        public Int32(int value) => _value = value;
        public static explicit operator Int32(int v)
        {
            return new Int32(v);
        }
        public static Fixed operator /(Int32 v1, Int32 v2)
        {
            return new Fixed(v1.Value / v2.Value);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
