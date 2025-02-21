using System;

class Program
{
    static int UCLN(int a, int b)
    {
        return b == 0 ? a : UCLN(b, a % b);
    }

    static void Main()
    {
        while(true)
        {
            try
            {
                Console.Write("Nhap a (nhap 0 0 de thoat): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhap b: ");
                int b = int.Parse(Console.ReadLine());

                if (a == 0 && b == 0) break;
                if (a < 1 || b < 1)
                {
                    Console.WriteLine("Vui long nhap hai so nguyen duong!");
                    continue;
                }

                int ucln_141 = TimUCLN(a, b);

                Console.WriteLine($"Uoc chung lon nhat cua {a} va {b} la: {ucln_141}");
            }
            catch (Exception)
            {
                Console.WriteLine("Loi nhap lieu! Vui long nhap so nguyen hop le.");
            }
        }
    }
}
