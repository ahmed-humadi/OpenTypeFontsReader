using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int16
    {
        private readonly short _value;
        public readonly short Value => _value;
        public Int16(short value) => _value = value;
    }
}
