using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        bool la_so_nguyen_to_141 = true; 

        if (n < 2)
        {
            la_so_nguyen_to_141 = false;
        }
        else
        {
            for (int i = 2; i *i < n; i++)
            {
                if (n % i == 0)
                {
                    la_so_nguyen_to_141 = false;
                    break;
                }
            }
        }

        if (la_so_nguyen_to_141)
            Console.WriteLine($"{n} la so nguyen to");
        else
            Console.WriteLine($"{n} khong phai so nguyen to");
    }
}
