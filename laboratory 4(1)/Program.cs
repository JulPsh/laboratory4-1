using System;

namespace laboratory_4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите число m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число p");
            int p = Convert.ToInt32(Console.ReadLine());
            if (m < 0)
                ++s;
            if (n < 0)
                ++s;
            if (p < 0)
                ++s;
            Console.Write("Отрицательных чисел {0}", s);
            Console.ReadLine();
        }
    }
}
