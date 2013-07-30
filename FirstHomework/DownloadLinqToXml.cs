using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FirstHomework
{
    class DownloadLinqToXml
    {
        internal XDocument OpenFileOnRead()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            XDocument doc = new XDocument();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                Console.WriteLine("\n");
                try
                {
                    doc = XDocument.Load(openFileDialog.FileName);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: Could not read file from disk. Original error: " + ex.Message);
                    doc = null;
                }
            }
            return doc;
        }

        private List<string> GetNames(XDocument doc)
        {
            List<string> fileNames = new List<string>();
            foreach (XElement fileEl in doc.Root.Elements())
            {
                fileNames.Add(fileEl.Value.ToString());
            }
            return fileNames;
        }

        internal void Comparefiles()
        {
            var fileToWrite = OpenFileOnRead();
            var fileToCompare = OpenFileOnRead();
            var compareNames = GetNames(fileToCompare);
            int index = 0;
            foreach (XElement fileEl in fileToWrite.Root.Elements())
            {
                if (fileEl.Value.ToString().Trim() != compareNames[index].Trim())
                {
                    Console.WriteLine("{0} : {1} имеет различия {2}", fileEl.Name, fileEl.Value, compareNames[index]);
                    index++;
                    continue;
                }
                Console.WriteLine("{0}:{1}", fileEl.Name,fileEl.Value);
                index++;
            }
         }

      }
}
