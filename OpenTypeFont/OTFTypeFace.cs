using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTypeFont.DataTypes;
using OpenTypeFont.IO;
namespace OpenTypeFont
{
    public class OTFTypeFace
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
                if(_oTFReader is null)
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
            throw new NotImplementedException();
        }
    }
}
