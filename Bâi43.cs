using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int so_luong_chu_so_141 = 0;

        int temp = n;
        while (temp > 0)
        {
            so_luong_chu_so_141++;
            temp /= 10;
        }

        Console.WriteLine($"So luong chu so cua {n} la: {so_luong_chu_so_141}");
    }
}
