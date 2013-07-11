using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomework
{
    class SaveClass
    {

        internal void SaveFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            //saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(saveFileDialog.FileName );
                using (var fileStream = new StreamWriter(saveFileDialog.FileName + ".xml"))
                {
                    HeadWriter(fileStream);
                    GetTitle(fileStream);
                    GetAuthor(fileStream);
                    GetCountPages(fileStream);
                    WetherRead(fileStream);
                    EndWriter(fileStream);
                }
            }
        }

        internal void HeadWriter(StreamWriter fileStream)
        {
            fileStream.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            fileStream.WriteLine("<Book>");
        }

        internal void EndWriter(StreamWriter fileStream)
        {
            fileStream.WriteLine("</Book>");
        }

        internal void GetTitle(StreamWriter fileStream)
        {
            Console.WriteLine("Введиите название книги : \n");
            string bookTitle = Console.ReadLine();
            fileStream.WriteLine("<BookTitle>");
            fileStream.WriteLine(bookTitle);
            fileStream.WriteLine("</BookTitle>");
        }

        internal void GetAuthor(StreamWriter fileStream)
        {
            Console.WriteLine("Введиите автора : \n");
            string bookAuthor = Console.ReadLine();
            fileStream.WriteLine("<BookAuthor>");
            fileStream.WriteLine(bookAuthor);
            fileStream.WriteLine("</BookAuthor>");
        }

        internal void GetCountPages(StreamWriter fileStream)
        {
            Console.WriteLine("Введиите количество страниц : \n");
            string countPages = Console.ReadLine();
            fileStream.WriteLine("<CountPages>");
            fileStream.WriteLine(countPages);
            fileStream.WriteLine("</CountPages>");
        }

        internal void WetherRead(StreamWriter fileStream)
        {
            Console.WriteLine("Ввведите 1 если книга прочитана, иначе 0 : \n");
            string outputLine = Console.ReadLine();
            fileStream.WriteLine("<WetherRead>");
            if ((outputLine != "1") && (outputLine != "0"))
            {
                Console.WriteLine("Ошибка! Введите либо 0 либо 1!\n");
                WetherRead(fileStream);
            }
            if (outputLine == "1")
            {
                fileStream.WriteLine("Прочитана");
                fileStream.WriteLine("</WetherRead>");
                return;
            }
            fileStream.WriteLine("Не прочитана");
            fileStream.WriteLine("</WetherRead>");
        }

    }
}
