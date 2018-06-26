using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_задача_3
{

    class Program
    {

        static int Vvodd(string s, out int n)//Вввод размера массива
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Введите " + s + " заново");
            } while (!ok);
            return n;
        }
        static void Check(string s, ref int a)// выполнение проверки
        {
            bool ok = false;
            string buf;
            do
            {
                if (a > 0) ok = true;
                else
                {
                    if (!ok) Console.WriteLine("Введите " + s + " заново");
                    Console.Write(s + " = ");
                    buf = Console.ReadLine();
                    ok = int.TryParse(buf, out a);
                    ok = false;
                }
            } while (!ok);
        }


        static void AddMas(out int[,] mas2, out int stroka, out int stolb)//формирование двумерного массива
        {
            int i, j, k = 20;
            bool p = false;
            Random a = new Random();

            Vvodd("Размерность массива", out stroka);
            stolb = stroka;
            mas2 = new int[stroka + k, stolb];
            do
            {
                for (i = 0; i < stroka; i++)
                {
                    for (j = 0; j < stolb; j++)
                    {
                        mas2[i, j] = a.Next(0, 100);
                        Console.Write("{0,4}", mas2[i, j]);
                    }
                    Console.WriteLine();
                }
                p = true;
            } while (p == false);
        }


        public static int Readint()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int intNum;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // Если попытка неудачная:
                if (!check)
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!check);
            // Если попытка удачная:
            return intNum;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int  stolb, stroka;
            int max = -1;
            int[,] mas2;
            AddMas(out mas2, out stroka, out stolb);


            for (int n = 0; n < stroka; n++)
            {
                for (int m = 0; m < stolb; m++)
                {
                    mas2[n, m] = rnd.Next(0, 100);
                }
                Console.WriteLine();
            }


            for (int n = 0; n < stroka; n++)
            {
                for (int m = 0; m < stolb; m++)
                {
                    if ((n<=m)&&(mas2[n, m] > max))
                        max = mas2[n, m];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент исследуемой области={0}", max);








        }
    }
}