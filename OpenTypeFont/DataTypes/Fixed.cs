using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTypeFont.DataTypes
{
    public readonly struct Fixed
    {
        private readonly float _value;
        public readonly float Value => _value;
        public Fixed(float value)
        {
            _value = value;
        }

    }
}
