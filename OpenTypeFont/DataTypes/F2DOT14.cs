using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct F2DOT14
    {
        private readonly float _value;
        public readonly float Value => _value;
        public F2DOT14(float value)
        {
            _value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
