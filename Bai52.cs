using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int chu_so_nho_nhat_141 = 9; 

        int temp = n;
        while (temp > 0)
        {
            int chu_so = temp % 10;
            if (chu_so < chu_so_nho_nhat_141)
            {
                chu_so_nho_nhat_141 = chu_so;
            }
            temp /= 10;
        }

        Console.WriteLine($"Chu so nho nhat cua {n} la: {chu_so_nho_nhat_141}");
    }
}
