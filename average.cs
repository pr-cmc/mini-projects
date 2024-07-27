using System;
class average
{
    static void Main(String[] args)
    {
        double k = 0;
        double c = 0;
        while (true)
        {
            double i = Convert.ToDouble(Console.ReadLine());
            if (i != 0)
            {
                c += i;
                k += 1;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(c / k);
    }
}