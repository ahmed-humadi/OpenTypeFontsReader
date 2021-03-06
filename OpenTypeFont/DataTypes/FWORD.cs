using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct FWORD
    {
        private readonly short _value;
        public readonly short Value => _value;
        public FWORD(short value)
        {
            _value = value;
        }
        public static explicit operator FWORD(Int16 v)
        {
            return new FWORD(v.Value);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
