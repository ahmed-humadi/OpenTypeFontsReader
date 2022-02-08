using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Uint24
    {
        private readonly uint _value;
        public readonly uint Value => _value;
        public Uint24(uint value) => _value = value;

        public static explicit operator Uint24(uint v)
        {
            // this will trim the first high-order bits from the uint
            return new Uint24((v & 0xFFFFFF)); 
        }
    }
}
