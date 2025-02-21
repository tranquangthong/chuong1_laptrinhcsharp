using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Vui long nhap so nguyen duong!");
                return;
            }

            int tong_141 = 0;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    tong_141 += i;
                    if (i != n / i)
                    {
                        tong_141 += n / i;
                    }
                }
            }

            Console.WriteLine($"Tong cac uoc cua n {n} = {tong_141}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Loi nhap lieu!");
        }
    }
}
