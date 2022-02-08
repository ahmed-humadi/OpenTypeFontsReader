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
    }
}
