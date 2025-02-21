using System;
using System.Linq;

class Program
{
    static int TimChuSoNhoNhat(int n)
    {
        return n.ToString().Min(c => c - '0');
    }
    static void Main()
    {
        while(true)
        {
            try
            {
                Console.Write("Nhap n(Nhap 0 de thoat):");
                int n = int.Parse(Console.ReadLine());
                if(n==0) break;
                if(n<1)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong!");
                    continue;
                }
                int chu_so_nho_nhat_141=TimChuSoNhoNhat(n);
            }
            catch(Exception)
            {
                Console.WriteLine("Loi nhap lieu! Vui long nhap so nguyen hop le.");
            }
        }

    }
}
