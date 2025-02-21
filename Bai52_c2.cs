using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int chu_so_nho_nhat_141 = n.ToString().Min(c => c - '0'); 

        Console.WriteLine($"Chu so nho nhat cua {n} la: {chu_so_nho_nhat_141}");
    }
}
