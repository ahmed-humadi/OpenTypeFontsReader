using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Uint16
    {
        private readonly ushort _value;
        public readonly ushort Value => _value;
        public Uint16(ushort value) => _value = value;
        public static explicit operator Uint16(ushort v)
        {
            return new Uint16(v);
        }
    }
}
