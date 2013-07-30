using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomework
{
    public class SaveStream
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
                using (var fileStream = new StreamWriter(saveFileDialog.FileName))
                {
                    HeadWriter(fileStream);
                    WriteTitle(fileStream, getInfo.GetTitle());
                    WriteAuthor(fileStream, getInfo.GetAuthor());
                    WriteCountPages(fileStream, getInfo.GetCountPages());
                    WriteWetherRead(fileStream, getInfo.WetherRead());
                    EndWriter(fileStream);
                }
            }
        }

        public void HeadWriter(StreamWriter fileStream)
        {
            fileStream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            fileStream.WriteLine("<Book>");
        }

        public void EndWriter(StreamWriter fileStream)
        {
            fileStream.WriteLine("</Book>");
        }

        public void WriteTitle(StreamWriter fileStream, string str)
        {
            fileStream.WriteLine("<BookTitle>" + str + "</BookTitle>");
        }

        public void WriteAuthor(StreamWriter fileStream, string str)
        {
            fileStream.WriteLine("<BookAuthor>" + str + "</BookAuthor>");
        }

        public void WriteCountPages(StreamWriter fileStream, string str)
        {
            fileStream.WriteLine("<CountPages>" + str + "</CountPages>");
        }

        public void WriteWetherRead(StreamWriter fileStream, string str)
        {
            fileStream.WriteLine("<WetherRead>" + str + "</WetherRead>");
        }


    }
}
