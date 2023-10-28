using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SamarAA.Sprint3.Task5.V19.Lib;

namespace Tyuiu.SamarAA.Sprint3.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Сумма ряда от i = 1 до i = 3 ( Сумма ряда от k=1 до k = 6 ((x/cosx)^k)  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int strtv1 = 1;
            int stpv1 = 3;
            int strtv2 = 1;
            int stpv2 = 6;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + strtv1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stpv1);
            Console.WriteLine("Старт шага второй суммы ряда = " + strtv2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stpv2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, strtv1, strtv2, stpv1, stpv2));

            Console.ReadKey();



        }
    }
}
