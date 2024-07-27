using System;
class Imt
{
    static void Main(String[] args)
    {
        Console.WriteLine("Введи свой рост в сантиметрах");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введи свою массу в килограммах");
        double weight = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow((height / 100), 2) / weight;
        if (result < 16)
        {
            Console.WriteLine("У вас недостаточный вес");
        }
        if (result >= 16 && result <= 18.5)
        {
            Console.WriteLine("У вас нормальный вес");
        }
        if (result >= 25 && result <= 30)
        {
            Console.WriteLine("У вас лишний вес");
        }
        if (result > 30)
        {
            Console.WriteLine("У вас ожирение");
        }
    }
}