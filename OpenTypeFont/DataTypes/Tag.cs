using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Tag
    {
        private readonly string _value;

        public readonly string Value => _value;

        public Tag(Uint8[] data)
        {
            _value = string.Empty;
            foreach(Uint8 e in data)
                _value +=(char)e;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
