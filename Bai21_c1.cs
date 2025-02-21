using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int tong_141 = 0; 

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) 
            {
                tong_141 += i;
            }
        }

        Console.WriteLine($"Tong cac uoc cua {n} = {tong_141}");
    }
}
