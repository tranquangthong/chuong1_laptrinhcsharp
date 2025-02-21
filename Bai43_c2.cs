using System;

class Program
{
    static int DemSoChuSo(int n)
    {
        return n.ToString().Length;
    }

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhap n (nhap 0 de thoat): ");
                int n = int.Parse(Console.ReadLine());

                if (n == 0) break;
                if (n < 1)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong!");
                    continue;
                }

                int so_luong_chu_so_141 = DemSoChuSo(n);

                Console.WriteLine($"So luong chu so cua {n} la: {so_luong_chu_so_141}");
            }
            catch (Exception)
            {
                Console.WriteLine("Loi nhap lieu! Vui long nhap so nguyen hop le.");
            }
        }
    }
}
