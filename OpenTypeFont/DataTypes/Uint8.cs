using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Uint8
    {
        private readonly byte _value;
        public readonly byte Value => _value;
        public Uint8(byte value) =>_value = value;
        public static explicit operator Uint8(byte b)
        {
            return new Uint8(b);
        }
    }
}
