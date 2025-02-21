using System;

class Program
{
    static int UCLN(int a, int b)
    {
        return b == 0 ? a : UCLN(b, a % b);
    }

    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        int ucln_141 = UCLN(a, b); 

        Console.WriteLine($"Uoc chung lon nhat cua {a} va {b} la: {ucln_141}");
    }
}
