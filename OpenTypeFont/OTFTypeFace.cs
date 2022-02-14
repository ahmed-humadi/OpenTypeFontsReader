using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OpenTypeFont.DataTypes;
using OpenTypeFont.IO;
namespace OpenTypeFont
{
    public class OTFTypeFace : IDisposable
    {
        private OpenTypeFontReader _oTFReader;
        private byte[] _fontBinaryData;

        public byte[] FontBinaryData
        {
            get { return _fontBinaryData; }
            set { _fontBinaryData = value; }
        }
        public OpenTypeFontReader OTFReader
        {
            get
            {
                if (_oTFReader is null)
                    _oTFReader = new OpenTypeFontReader(FontBinaryData);
                return _oTFReader;
            }
            set { _oTFReader = value; }
        }
        public OTFTypeFace(byte[] fontData)
        {
            if (_fontBinaryData is null && fontData.Length > 0)
                _fontBinaryData = fontData;
            else
                throw new ArgumentNullException(nameof(_fontBinaryData));
            this.InitializeFontTables();
        }
        private void InitializeFontTables()
        {
            // Table Directory
            Uint32 sfntVersion = this.OTFReader.ReadUint32();
            if (sfntVersion == (Uint32)0x4F54544F)
            {
                // this CFF 1 / 2

            }
            Uint16 numbTables = this.OTFReader.ReadUint16();
            Uint16 searchRange = this.OTFReader.ReadUint16();
            Uint16 entrySelector = this.OTFReader.ReadUint16();
            Uint16 rangeShift = this.OTFReader.ReadUint16();
            TableRecord[] tableRecords = new TableRecord[numbTables];
            for (int i = 0; i < numbTables; i++)
            {
                tableRecords[i] = new TableRecord()
                {
                    TableTag = this.OTFReader.ReadTag(),
                    Checksum = this.OTFReader.ReadUint32(),
                    TableOffset = this.OTFReader.ReadUint32(),
                    TableLength = this.OTFReader.ReadUint32()
                };
            }
        }
        public void Dispose()
        {
            if (_oTFReader is not null)
                _oTFReader.Dispose();
        }
    }
    struct TableRecord
    {
        private Tag _tableTag;

        public Tag TableTag
        {
            get { return _tableTag; }
            set { _tableTag = value; }
        }
        private Uint32 _checksum;

        public Uint32 Checksum
        {
            get { return _checksum; }
            set { _checksum = value; }
        }
        private Uint32 _tableOffset;

        public Uint32 TableOffset
        {
            get { return _tableOffset; }
            set { _tableOffset = value; }
        }
        private Uint32 _tableLength;

        public Uint32 TableLength
        {
            get { return _tableLength; }
            set { _tableLength = value; }
        }
        public override string ToString()
        {
            return TableTag.ToString();
        }
    }
}
