using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ��������_������_3
{

    class Program
    {

        static int Vvodd(string s, out int n)//����� ������� �������
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok) Console.WriteLine("������� " + s + " ������");
            } while (!ok);
            return n;
        }
        static void Check(string s, ref int a)// ���������� ��������
        {
            bool ok = false;
            string buf;
            do
            {
                if (a > 0) ok = true;
                else
                {
                    if (!ok) Console.WriteLine("������� " + s + " ������");
                    Console.Write(s + " = ");
                    buf = Console.ReadLine();
                    ok = int.TryParse(buf, out a);
                    ok = false;
                }
            } while (!ok);
        }


        static void AddMas(out int[,] mas2, out int stroka, out int stolb)//������������ ���������� �������
        {
            int i, j, k = 20;
            bool p = false;
            Random a = new Random();

            Vvodd("����������� �������", out stroka);
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
        //���� ����� ��� �������� ���
        {
            bool check = false;
            int intNum;
            do
            {
                // ������� ��������� ������ � �����
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // ���� ������� ���������:
                if (!check)
                    Console.WriteLine("������������ ����. ���������� ��� ���");
            } while (!check);
            // ���� ������� �������:
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
            Console.WriteLine("������������ ������� ����������� �������={0}", max);








        }
    }
}