using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OTFDataType =  OpenTypeFont.DataTypes; // for ambgiusty
namespace OpenTypeFont.IO
{
    public class OpenTypeFontReader : IDisposable       
    {
        private BinaryReader _binaryReader;
        public BinaryReader BinaryReader
        {
            get { return _binaryReader; }
            set { _binaryReader = value; }
        }
        public OpenTypeFontReader(byte[] fontData)
        {
            this.BinaryReader = new BinaryReader(new MemoryStream(fontData));
        }
        public OTFDataType.Uint8 ReadUint8()
        {
            return (OTFDataType.Uint8)this.BinaryReader.ReadByte();
        }
        public OTFDataType.Int8 ReadInt8()
        {
            return (OTFDataType.Int8)this.BinaryReader.ReadSByte();
        }
        public OTFDataType.Uint16 ReadUint16()
        {
            byte[] b = this.BinaryReader.ReadBytes(2);

            Array.Reverse<byte>(b);

            return (OTFDataType.Uint16)BitConverter.ToUInt16(b);
        }
        public OTFDataType.Int16 ReadInt16()
        {
            byte[] b = this.BinaryReader.ReadBytes(2);

            Array.Reverse<byte>(b);

            return (OTFDataType.Int16)BitConverter.ToInt16(b);
        }
        public OTFDataType.Uint24 ReadUint24()
        {
            byte[] b = this.BinaryReader.ReadBytes(3);

            Array.Reverse<byte>(b);

            uint v = (uint)b[0] << 16 | (uint)b[1] << 8 | (uint)b[2];

            return (OTFDataType.Uint24)v;
        }
        public OTFDataType.Int24 ReadInt24()
        {
            byte[] b = this.BinaryReader.ReadBytes(3);

            Array.Reverse<byte>(b);

            int v = (sbyte)b[0] << 16 | b[1] << 8 | b[2];

           return (OTFDataType.Int24)v;
        }
        public OTFDataType.Int32 ReadInt32()
        {
            byte[] b = this.BinaryReader.ReadBytes(4);

            Array.Reverse<byte>(b);

            return (OTFDataType.Int32)BitConverter.ToInt32(b);
        }
        public OTFDataType.Uint32 ReadUint32()
        {
            byte[] b = this.BinaryReader.ReadBytes(4);

            Array.Reverse<byte>(b);

            return (OTFDataType.Uint32)BitConverter.ToUInt32(b);
        }
        public OTFDataType.Fixed ReadFixed()
        {
            return ReadInt32() / (OTFDataType.Int32)(1 << 16);
        }
        public OTFDataType.FWORD ReadFWord()
        {
            return (OTFDataType.FWORD)ReadInt16();
        }
        public OTFDataType.UFWORD ReadUFWord()
        {
            return (OTFDataType.UFWORD)ReadUint16();
        }
        public OTFDataType.F2DOT14 ReadF2DOT14()
        {
            return ReadInt16() / (OTFDataType.Int16)(1 << 14);
        }
        public OTFDataType.Tag ReadTag()
        {
            OTFDataType.Uint8[] tag = new OTFDataType.Uint8[4];
            for (int i = 0; i < 4; i++)
                tag[i] = ReadUint8();
            return new OTFDataType.Tag(tag);
        }

        public void Dispose()
        {
            if (_binaryReader is not null)
            {
                _binaryReader.Dispose();
                _binaryReader = null;
            }
        }
    }
}
