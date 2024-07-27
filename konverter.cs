using System;
class konverter
{
    static void Main(String[] args)
    {
        Console.WriteLine("m/s -> km/h - 1; km/h -> m/s - 2");
        String v = Console.ReadLine();
        if (v == "1")
        {
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n1 * 3.6);
        }
        if (v == "2")
        {
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((n2 * 1000) / 3600);
        }
    }
}
