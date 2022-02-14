using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Uint32
    {
        private readonly uint _value;
        public readonly uint Value => _value;
        public Uint32(uint value) => _value = value;

        public static explicit operator Uint32(uint v)
        {
            return new Uint32(v);
        }
        public static explicit operator int(Uint32 v)
        {
            return (int)v.Value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public static bool operator ==(Uint32 v1, Uint32 v2)
        {
            if (v1.Value == v2.Value)
                return true;
            else
                return false;
        }
        public static bool operator !=(Uint32 v1, Uint32 v2)
        {
            if (v1.Value != v2.Value)
                return true;
            else
                return false;
        }
    }
}
