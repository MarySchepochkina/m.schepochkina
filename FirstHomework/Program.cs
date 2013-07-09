using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Check a point to continue: \n 0.Save information \n 2.Download information\n");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a) {
                case 0:
                //    Console.WriteLine("");
                    Console.ReadKey();
                    break;
                case 1:
                 //   Console.WriteLine("you take 1");
                    Console.ReadKey();
                    break;
                                       
            }

        }
    }
}
