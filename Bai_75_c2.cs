using System;

class Program
{
    static bool LaSoDangHaiMuK(int n_141)
    {
        return n_141 > 0 && (n_141 & (n_141 - 1)) == 0;
    }

    static void Main()
    {
        Console.Write("Nhap so nguyen duong: ");
        int n_141 = int.Parse(Console.ReadLine());

        if (LaSoDangHaiMuK(n_141))
            Console.WriteLine($"{n_141} la so dang 2^k.");
        else
            Console.WriteLine($"{n_141} khong phai so dang 2^k.");
    }
}
