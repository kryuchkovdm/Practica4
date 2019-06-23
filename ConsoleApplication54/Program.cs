using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Try(out double inputnumber)//проверка правильности ввода числа
        {
            inputnumber = 0;
            bool flag = true;
            while (flag == true)
            {
                try
                {

                    string x = Console.ReadLine();
                    inputnumber = double.Parse(x);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Введите положительное число");
                    flag = true;
                }

            }
        }
        static double F(double a)
        {
            double answer = Math.Pow(a, 2) - Math.Sin(5 * a);
            return answer;

        }
        static void Main(string[] args)
        {
            string answer = "yes";

            while (answer == "yes")
            {

                Console.WriteLine("Введите e");
                Console.Write("e=");
                double e;
                bool f1 = true;
                Try(out e);
                while (f1 && e < 0)
                {
                    Console.WriteLine("Неверное значение! Введите положительное число");
                    Try(out e);
                    if (e >= 0)
                    {
                        f1 = false;
                    }
                }
                double a = 0.5;
                double b = 0.6;
                double x = a - F(a) * (b - a) / (F(b) - F(a));
                bool f = true;
                double res = F(a);
                while (f && res * F(b) < 0)
                {
                    double x0 = x;
                    x = x - F(x) * (b - x) / (F(b) - F(x));
                    res = F(x);
                    f = Math.Abs(x - x0) > e;
                }
                Console.WriteLine("X={0}", x);
                Console.WriteLine("Продолжить? yes/no");
                answer = Console.ReadLine();

            }

        }
    }
}

