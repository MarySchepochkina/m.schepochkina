using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FirstHomework
{
    class SaveLinqXml
    {
        internal void SaveFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            //saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(saveFileDialog.FileName);
                var getInfo = new GetInformation();
                XDocument xDocument = new XDocument(
                    new XElement ("Book",
                        new XElement("BookTitle", getInfo.GetTitle()),
                        new XElement("BookAuthor", getInfo.GetAuthor()),
                        new XElement("CountPages", getInfo.GetCountPages()),
                        new XElement("WetherRead", getInfo.WetherRead())));
                xDocument.Save(saveFileDialog.FileName);
            }
        }

        
    }
}
