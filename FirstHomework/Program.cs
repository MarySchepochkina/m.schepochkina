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
            
            Console.WriteLine("Check a point to continue: \n 0.Save information \n 2.Download information\n");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a) {
                case 0:
                    SaveClass saveClass = new SaveClass();
                    saveClass.saveFile();
                    Console.ReadKey();
                    break;
                case 1:

                    Console.ReadKey();
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
