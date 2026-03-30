using System;
using System.Diagnostics;
//Author: Dao Minh Tuan - 2500115853
//Muc tieu:
//Bai 1: Nhap ten va MSSV, in ra loi chao.
//Code: sử dụng Console.ReadLine() để gán biến.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap ho ten: ");
        String name = Console.ReadLine();
        Console.Write("Nhap MSSV: ");
        String mssv = Console.ReadLine();
        Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv}) den voi lop CTDL&GT!");
//      Bài 2: Máy tính cơ bản
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tong: {a + b}");
        Console.WriteLine($"Hieu: {a - b}");
        Console.WriteLine($"Tich: {a * b}");
        if (b != 0)
        {
            Console.WriteLine($"Thuong: {(double)a / b}");
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }
        int x = 5, y = 10;
        Console.WriteLine($"Truoc khi swap: x={x}, y={y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Sau khi swap: x={x}, y={y}");
    }
}