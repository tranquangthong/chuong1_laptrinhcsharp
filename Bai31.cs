using System;

class Program
{
    static void Main()
    {
        try
        {
                    Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        bool la_so_nguyen_to_141 = true; 

        if (n < 1)
        {
            Console.WriteLine("Vui long nhap so nguyen duong!");
        }
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
        catch (Exception)
        {
            Console.WriteLine("Loi nhap lieu! Vui long nhap so nguyen hop le.");
        }
    }

}
