using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomework
{
    public class DownloadStream
    {
        internal void OutputFiles()
        {
            
            Console.WriteLine("Выбирите файл для открытия, затем для сравнения: ");
            var outputFile = OpenFileOnRead();
            var compareFile = OpenFileOnRead();
            using (outputFile)
            {
                using (compareFile)
                {
                    while (outputFile.Peek() >= 0)
                    {
                        string outputFileStr = ReadLineFromFile(outputFile);
                        string compareFileStr = ReadLineFromFile(compareFile);
                        if (CompareLines(outputFileStr, compareFileStr) == false)
                        {
                            Console.WriteLine(outputFileStr  + "имеет различия:" + compareFileStr);
                            continue;
                        }

                        Console.WriteLine(outputFileStr);
                    }
                }
            }
        }


        internal StreamReader OpenFileOnRead()
        {
            var openFileDialog = new OpenFileDialog();
            string num = Console.ReadLine();
            StreamReader streamReader = null;
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                try
                {
                    streamReader = new StreamReader(openFileDialog.OpenFile());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: Could not read file from disk. Original error: " + ex.Message);
                    streamReader = null;
                }
            }
            return streamReader;
        }

        public string ReadLineFromFile(StreamReader fileStream)
        {
            var currentStr = fileStream.ReadLine();
            return currentStr;
        }

        public bool CompareLines(string firstStr, string secondStr)
        {
            if (firstStr.Trim() == secondStr.Trim())
            {
                return true;
            }
            return false;
        }
    }
}
