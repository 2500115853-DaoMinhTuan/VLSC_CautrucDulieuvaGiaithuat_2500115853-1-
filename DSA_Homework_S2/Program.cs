using System;
class Program
{
    static int TinhTong(int n)
    {
        if (n == 1) return 1;
        return n + TinhTong(n - 1);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap n de tinh tong: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tong S({n}) = {TinhTong(n)}");
    }
}