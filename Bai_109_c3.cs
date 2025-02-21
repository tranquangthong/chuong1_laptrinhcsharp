using System;

class Program
{
    static void Main()
    {
        for (int so_141 = 2; so_141 <= 9; so_141++)
        {
            Console.WriteLine($"\nBang cuu chuong {so_141}:");
            for (int i_141 = 1; i_141 <= 10; i_141++)
            {
                Console.WriteLine($"{so_141} x {i_141} = {so_141 * i_141}");
            }
        }
    }
}
