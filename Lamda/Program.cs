using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int g = 0;
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                ++s;
            if (b < 0)
                ++s;
            if (c < 0)
                ++s;
            else
                if (a > 0)
                ++g;
            if (b > 0)
                ++g;
            if (c > 0)
                ++g;
            Console.Write("Положительные числа:{0}", g);
            Console.Write("Отрицательные: {0}", s);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}