using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FirstHomework
{

    class Program
    {
        public static void Menu()
        {

            Console.WriteLine("Выберете действие: \n 0.Сохранить информацию \n 1.Загрузить информацию\n 2.Выход");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            switch (firstNum)
            {
                case 0:
                    Console.WriteLine("Каким способам сохранить: \n 0.потоки \n 1.Limq to Xml\n");
                    var secondNum = Convert.ToInt32(Console.ReadLine());
                    switch (secondNum)
                    {
                        case 0:
                            var saveStream = new SaveStream();
                            saveStream.SaveFile();
                            Console.WriteLine("Файл сохранен\n\n");
                            Console.ReadKey();
                            Menu();
                            break;
                        case 1:
                            var saveLtoX = new SaveLinqXml();
                            saveLtoX.SaveFile();
                            Console.WriteLine("Файл сохранен\n\n");
                            Console.ReadKey();
                            Menu();
                            break;
                    }
                    break;
                case 1:
                    Console.WriteLine("Внимание! Загружаемый файл должен удовлетворять следующим требованиям форматирования:");
                    Console.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?> \n <Book> \n <BookTitle>название</BookTitle>");
                    Console.WriteLine("<BookAuthor>автор</BookAuthor>\n<CountPages>количество страниц</CountPages>\n<WetherRead>прочитана/нет</WetherRead>\n</Book>\n");
                    Console.WriteLine("Каким способам загрузить: \n 0.потоки \n 1.Limq to Xml\n");
                    var thirdNum = Convert.ToInt32(Console.ReadLine());
                    switch (thirdNum)
                    {
                        case 0:
                            var downlodStream = new DownloadStream();
                            downlodStream.OutputFiles();
                            Console.WriteLine("\n");
                            Console.ReadKey();
                            Menu();
                            break;
                        case 1:
                            var downloadLToXml = new DownloadLinqToXml();
                            downloadLToXml.Comparefiles();
                            Console.WriteLine("\n");
                            Console.ReadKey();
                            Menu();
                            break;
                    }
                    break;

                case 2:
                    break;
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
