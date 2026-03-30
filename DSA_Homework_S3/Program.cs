using System;
using System.Diagnostics;//Thu vien de do thoi gian thuc te
//Author: Dao Minh Tuan - 2500115853
//Muc tieu: So sanh hieu nang giua Linear Search va Binary Search tren mang da sap xep voi 10 trieu phan tu

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //---BÀI TẬP 2: So sanh thuc te voi 10 trieu phan tu---
        int n = 10000000; // 10 trieu phan tu
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = i;

        int target = 9999999; // tim phan tu cuoi cung(Truong hop xau nhat)
        Stopwatch sw = new Stopwatch();

        Console.WriteLine($"--- Thu nghiem voi {n} phan tu ---");

        //1. Do thoi gian tim kiem tuan tu (Linear Search)
        sw.Start();
        int res1 = LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine($"[Linear Search] Index: {res1}, Time: {sw.Elapsed.TotalMilliseconds} ms");
        //2.Do thoi gian tim kiem nhi phan de quy (Binary Search Recursive)
        sw.Restart();
        int res2 = BinarySearchRecursive(arr, 0, n - 1, target);
        sw.Stop();
        Console.WriteLine($"[Binary Search Recursive] Index: {res2}, Time: {sw.Elapsed.TotalMilliseconds} ms");

        //Cai dat tim kiem tuan tu - Do phuc tap 0(n)
        static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }            

            return -1;
        }

        //Cai dat tim kiem nhi phan de quy - do phuc tap 0(log n)
        static int BinarySearchRecursive(int[] arr, int left, int right, int x)
        {
            //Dieu kien dung: Khi vi pham vi tim kiem khong con hop le
            if (left > right) return -1;
            //Tinh vi tri o giua
            int mid = left + (right - left) / 2;
            //Neu tim thay tai mid
            if (arr[mid] == x) return mid;
            //Neu x nho hon gia tri tai mid, tim o nua ben trai
            if (arr[mid] > x)
                return BinarySearchRecursive(arr, left, mid -1, x);
            //Nguoc lai tim o nua ben phai
            return BinarySearchRecursive(arr, mid + 1, right, x);
        }
    }
}