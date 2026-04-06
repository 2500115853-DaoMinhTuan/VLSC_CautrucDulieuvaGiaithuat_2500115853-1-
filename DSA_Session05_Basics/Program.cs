namespace DSA_Session05_Basics;

class Program
{
    static void Main(string[] args)
    {
        //Bai 1: Hoan doi 2 so khong dung bien tam(Toan hoc)
        //Goi y: Dung phep cong va tru
        //nguoi dung co the nhap 2 so tu ban phim va sau do thuc hien hoan doi
        Console.WriteLine("Bai 1: Hoan doi 2 so khong dung bien tam");
        Console.Write("Nhap so a: ");
        //Doc chuoi nhbap tu ban phim va luu vao bien inputA
        string inputA = Console.ReadLine();
        //SSu dung int.Parse de chuyen doi chuoi nhap vao thanh so nguyen,
        //Neu khong hop le thi yeu cau nguoi dung nhap lai.
        int a;
        while (!int.TryParse(inputA, out a))
        {
            Console.Write("So a khong hop le. Vui long nhap lai: ");
            inputA = Console.ReadLine();
        }
        Console.Write("Nhap so b: ");
        //Doc chuoi nhap vao tu ban phim va luu vao bien inputB
        string inputB = Console.ReadLine();
        //Su dung int.TryParse de chuyen doi chuoi nhap vao thanh so nguyen,
        //neu khong hop le thi yeu cau nguoi dung nhap lai.
        int b;
        while (!int.TryParse(inputB, out b))
        {
            Console.Write("So b khong hop le. Vui long nhap lai: ");
            inputB = Console.ReadLine();
        }
        a = a + b; // Cong a va b, ket qua luu vao a
        b = a - b; // Lay gia tri moi cua a tru di b,
        //Ket qua luu vao b (b gio la gia tri ban dau cua a)
        a = a - b; // Lay gia tri moi cua a tru di b,
        //Ket qua luu vao a (a gio la gia tri ban dau cua b)
        Console.WriteLine($"a={a}, b={b}");

        Console.WriteLine("================================");
        Console.WriteLine("Bai 2: Ve hinh vuong dau sao (n x n)");
        //nguoi dung co the nhap kich thuoc n tu ban phim
        //va sau do in ra hinh vuong tuong ung
        Console.Write("Nhap kich thuoc n cua hinh vuong: ");
        string inputN = Console.ReadLine();
        int n;//Su dung int.TryParse de chuyen doi chuoi nhap vao thanh so nguyen,
        //neu khong hop le thi yeu cau nguoi dung nhap lai.
        //n > 0
        while (!int.TryParse(inputN, out n) || n <= 0)
        {
            Console.Write("Kich thuoc n khong hop le. Vui long nhap lai: ");
            inputN = Console.ReadLine();
        }
        //Dung 2 vong lap for de in ra hinh vuong dau sao
        for (int i = 0; i < n; i++)
        {//Duyet hang
            for (int j = 0; j < n; j++)
            {//Duyet cot
                Console.Write("* ");
            }
            Console.WriteLine(); ////Xung dong sau moi hang
        }

        Console.WriteLine("================================");
        Console.WriteLine("Bai 3: In bang cuu chuong (2 den 9)");
        for (int i = 2; i <= 9; i++)
        {
            Console.WriteLine($"--- Bang cuu chuong {i} ---");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}