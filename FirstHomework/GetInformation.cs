using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class GetInformation
    {
        internal string GetTitle()
        {
            Console.WriteLine("Введиите название книги :");
            string bookTitle = Console.ReadLine();
            if (bookTitle.Trim() == "")
            {
                Console.WriteLine("Поле будет пустым! Продолжить 1, ввести 0/n");
                if (Console.ReadLine() == "0")
                {
                    GetTitle();
                }
            }
            return bookTitle;
        }

        internal string GetAuthor()
        {
            Console.WriteLine("Введиите автора :");
            string bookAuthor = Console.ReadLine();
            if (bookAuthor.Trim() == "")
            {
                Console.WriteLine("Поле будет пустым! Продолжить 1, ввести 0/n");
                if (Console.ReadLine() == "0")
                {
                    GetAuthor();
                }
            }
            return bookAuthor;
        }

        internal string GetCountPages()
        {
            Console.WriteLine("Введиите количество страниц :");
            var stringCountPages = Console.ReadLine();
            if (stringCountPages.Trim() == "")
            {
                Console.WriteLine("Поле будет пустым! Продолжить 1, ввести 0/n");
                if (Console.ReadLine() == "1")
                {
                    return "";
                }
                GetCountPages();
            }
            if (Convert.ToInt32(stringCountPages) <= 0)
            {
                Console.WriteLine("Количество страниц не может быть меньше 0!/n");
                GetCountPages();
            }
            return stringCountPages;
        }

        internal string WetherRead()
        {
            Console.WriteLine("Ввведите 1 если книга прочитана, иначе 0 : ");
            string outputLine = Console.ReadLine();
            if ((outputLine != "1") && (outputLine != "0"))
            {
                Console.WriteLine("Ошибка! Введите либо 0 либо 1!\n");
                WetherRead();
            }
            if (outputLine == "1")
            {
                return "прочитана";
            }
            return "не прочитана";
        }
    }
}
