using System;

class Program
{
    static long GiaiThua(int x)
    {
        if (x == 1) return 1;
        return x * GiaiThua(x - 1);
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        long tong_141 = 0;

        for (int i = 1; i <= n; i++)
        {
            tong_141 += GiaiThua(i);
        }

        Console.WriteLine($"Tong S(n) = {tong_141}");
    }
}