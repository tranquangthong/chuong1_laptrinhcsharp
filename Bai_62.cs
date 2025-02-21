using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        int ucln_141;
        int x = a, y = b; // Biến có 3 số cuối mã sinh viên

        while (x != y)
        {
            if (x > y) x -= y;
            else y -= x;
        }
        ucln_141 = x;

        Console.WriteLine($"Uoc chung lon nhat cua {a} va {b} la: {ucln_141}");
    }
}
