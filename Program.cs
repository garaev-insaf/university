using System;

namespace helping1
{
    public class Class1
    {
        private static void Main()
        {
            Console.WriteLine("Input n: ");
            long n = Convert.ToInt64(Console.ReadLine());
            long d = 2;
            long x = 0; // запоминает наибольший простой делитель
            while (d < n)
            {
                bool flag = false; // флаг "поднимется", если делитель не простой
                // проверка: делится ли без остатка
                if (n % d == 0)
                {
                    // цикл на проверку простоты делителя
                    for (long i = 2; i < d; i++)
                    {
                        if (i != d && d % i == 0)
                        {
                            flag = true;
                        }
                    }
                }
                // присваивание наибольшего просто числа
                if (flag == false && n % d == 0)
                {
                    x = d;
                }
                d++;
            }
            if (x == 0)
            {
                Console.WriteLine("Простой делитель отсутствует");
            }
            else
            {
                Console.WriteLine("Наибольший простой делитель: {0}", x);
            }

        }

    }
}
