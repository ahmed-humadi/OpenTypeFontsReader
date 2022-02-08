using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Int32
    {
        private readonly int _value;
        public readonly int Value => _value;
        public Int32(int value) => _value = value;
    }
}
