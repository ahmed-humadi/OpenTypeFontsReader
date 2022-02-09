using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenTypeFontDataType =  OpenTypeFont.DataTypes; // for ambgiusty
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
        public OpenTypeFontDataType.Uint8 ReadUint8()
        {
            return (OpenTypeFontDataType.Uint8)this.OTFReader.ReadByte();
        }
        public OpenTypeFontDataType.Int8 ReadInt8()
        {
            return (OpenTypeFontDataType.Int8)this.OTFReader.ReadSByte();
        }
        public OpenTypeFontDataType.Uint16 ReadUint16()
        {
            byte[] b = this.OTFReader.ReadBytes(2);

            Array.Reverse<byte>(b);

            return (OpenTypeFontDataType.Uint16)BitConverter.ToUInt16(b);
        }
        public OpenTypeFontDataType.Int16 ReadInt16()
        {
            byte[] b = this.OTFReader.ReadBytes(2);

            Array.Reverse<byte>(b);

            return (OpenTypeFontDataType.Int16)BitConverter.ToInt16(b);
        }
        public OpenTypeFontDataType.Uint24 ReadUint24()
        {
            byte[] b = this.OTFReader.ReadBytes(3);

            Array.Reverse<byte>(b);

            uint v = ((uint)b[0] << 16 | (uint)b[1] << 8 | (uint)b[2]);

            return (OpenTypeFontDataType.Uint24)v;
        }
        public OpenTypeFontDataType.Int24 ReadInt24()
        {
            byte[] b = this.OTFReader.ReadBytes(3);

            Array.Reverse<byte>(b);

            int v = (sbyte)b[0] << 16 | b[1] << 8 | b[2];

           return (OpenTypeFontDataType.Int24)v;
        }
    }
}
