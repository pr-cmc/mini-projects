using System;
class factorial
{
    static void Main(String[] args)
    {
        double n = Convert.ToInt32(Console.ReadLine());
        for (double r = 1; n != 0; --n)
        {
            Console.WriteLine(r *= n);
        }
    }
}
