using System.Windows;
using System.Xml;

namespace ClientForFPGAService
{
    /// <summary>
    /// Логика взаимодействия для CodeViewerWindow.xaml
    /// </summary>
    public partial class CodeViewerWindow
    {
        public CodeViewerWindow()
        {
            InitializeComponent();
        }

        private void BrowseXmlFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "XML Files (*.xml)|*.xml|All Files(*.*)|*.*";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() != true) { return; }

            XmlDocument XMLdoc = new XmlDocument();
            try
            {
                XMLdoc.Load(dlg.FileName);
            }
            catch (XmlException)
            {
                MessageBox.Show("The XML file is invalid");
                return;
            }

            txtFilePath.Text = dlg.FileName;
            vXMLViwer.xmlDocument = XMLdoc;
        }

        private void ClearXmlFile(object sender, RoutedEventArgs e)
        {
            txtFilePath.Text = string.Empty;
            vXMLViwer.xmlDocument = null;
        }
    }
}
