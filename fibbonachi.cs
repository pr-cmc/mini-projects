using System;
class Fibbonachi
{
    static void Main(String[] args)
    {
        double o = 0;
        double t = 1;
        double r = 0;
        Console.WriteLine("Введите количество чисел Фиббоначи");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; ++i)
        {
            r = o + t;
            o = t;
            t = r;
            Console.Write($"{r}, ");
        }
    }
}