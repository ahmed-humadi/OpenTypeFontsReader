using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct UFWORD
    {
        private readonly ushort _value;
        public readonly ushort Value => _value;
        public UFWORD(ushort value)
        {
            _value = value;
        }
        public static explicit operator UFWORD(Uint16 v)
        {
            return new UFWORD(v.Value);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
