using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using OpenTypeFont.DataTypes;
using OpenTypeFont.IO;
using OpenTypeFont;
namespace OpenTypeFontsReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadFontFile();
        }

        private void ReadFontFile()
        {
            //Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            //if(openFileDialog.ShowDialog() = true)
            //{

            //}
            FileStream stream = new FileStream(@"F:\OpenTypeFonts\MontserratAlternates-Black.otf", FileMode.Open, FileAccess.Read);
            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData);
            using (OTFTypeFace oTFTypeFace = new OTFTypeFace(fontData))
            {

            }
        }
    }
}
