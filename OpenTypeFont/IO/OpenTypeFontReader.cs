using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenTypeFont.DataTypes;
namespace OpenTypeFont.IO
{
    public class OpenTypeFontReader
    {
        private BinaryReader _oTFReader;
        public BinaryReader OTFReader
        {
            get { return _oTFReader; }
            set { _oTFReader = value; }
        }
        public OpenTypeFontReader(byte[] fontData)
        {
            this.OTFReader = new BinaryReader(new MemoryStream(fontData));
        }
        public Uint8 ReadUint8()
        {
            return (Uint8)this.OTFReader.ReadByte();
        }
        public Int8 ReadInt8()
        {
            return (Int8)this.OTFReader.ReadSByte();
        }
        public Uint16 ReadUint16()
        {
            byte[] b = this.OTFReader.ReadBytes(2);

            Array.Reverse(b);

            return (Uint16)BitConverter.ToUInt16(b);
        }
    }
}
