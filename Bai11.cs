using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        long giaiThua = 1;
        long tong_141 = 0; 

        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
            tong_141 += giaiThua;
        }

        Console.WriteLine($"Tong S(n) = {tong_141}");
    }
}
