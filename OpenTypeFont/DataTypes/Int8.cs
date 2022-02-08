using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int8
    {
        private readonly sbyte _value;
        public readonly sbyte Value => _value;
        public Int8(sbyte value) => _value = value;
        public static explicit operator Int8(sbyte sb)
        {
            return new Int8(sb);
        }
    }
}
