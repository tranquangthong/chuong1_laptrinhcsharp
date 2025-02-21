using System;

class Program
{
    static void XuatKyTu(char bat_dau, char ket_thuc, bool inTheoDong)
    {
        for (char ky_tu_141 = bat_dau; ky_tu_141 <= ket_thuc; ky_tu_141++)
        {
            if (inTheoDong)
                Console.Write(ky_tu_141 + " ");
            else
                Console.WriteLine(ky_tu_141);
        }
    }

    static void Main()
    {
        Console.Write("Ban muon in ky tu in hoa (H) hay in thuong (T)? ");
        char lua_chon = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Ban muon hien thi theo dong (D) hay theo cot (C)? ");
        char cach_xuat = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        char bat_dau = (lua_chon == 'H') ? 'A' : 'a';
        char ket_thuc = (lua_chon == 'H') ? 'Z' : 'z';
        bool inTheoDong = (cach_xuat == 'D');

        XuatKyTu(bat_dau, ket_thuc, inTheoDong);
    }
}
