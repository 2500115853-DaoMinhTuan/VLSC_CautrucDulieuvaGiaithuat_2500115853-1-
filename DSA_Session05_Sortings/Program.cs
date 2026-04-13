namespace DSA_Session05_Sortings;

class Program
{
    static void Main(string[] args)
    {//Nhap mang tu nguoi dung
        int[] arr = InputArray();
        ////Tao ban sao cua mang de su dung cho thuat toan khac
        int[] arrCopy = (int [])arr.Clone();
        Console.WriteLine("Mang ban dau: ");
        PrintArray(arr);
        BubbleSort(arr);
        Console.WriteLine("Mang sau khi sap xep (Bubble Sort): ");
        PrintArray(arr);
        InsertSort(arrCopy);
        Console.WriteLine("Mang sau khi sap xep (Insert Sort): ");
        PrintArray(arrCopy);
    }
    //Ham de nhap mang tu nguoi dung
    private static int[] InputArray()
    {
        Console.WriteLine("Nhap so luong phan tu: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Nhap mot so nguyen hop le: ");
        }
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu: ");
        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Nhap mot so nguyen hop le: ");
            }
        }
        return arr;
    }
    //Ham de in mang
    private static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    //3.1 Bubble Sort(Sap xep noi bot)
    //Nguyen ly: So sanh tung cap phan tu lien ke va hoan doi neu chung
    //khong theo thu tu dung.
    //Qua trinh nay lap lai den khi khong con hoan doi nao can thiet.
    //Cach hoat dong: Bat dau tu phan tu dau tien,
    //So sanh no voi phan tu tiep theo va hoan doi neu can.
    //Do phuc tap: 0(n^2) trong truong hop xau nhat,
    // 0(n) trong truong hop tot nhat(khi mang da sap xep).
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        int swapCount = 0;
        for (int i = 0; i < n - 1; i++)
        //Duyet qua tat ca phan tu, tru phan tu cuoi cung
        {
            for(int j = 0; j < n - i - 1; i++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapCount++;
                }
            }
        }
        Console.WriteLine($"Bubble Sort ton {swapCount} lan hoan doi");
    }
    //3.2 Insert Sort(Sap xep chen)
    //Nguyen ly: Lay tung phan tu va chen no vao vi tri dung trong phan mang da sap xep.
    //(giong xep bai tay)
    //Cach hoat dong: Bat dau tu phan tu thu hai,
    // so sanh no voi cac phan tu truoc do va chen no vao vi tri dung.
    //Do phuc tap: 0(n^2) trong truong hop xau nhat,
    // 0(n) trong truong hop tot nhat(khi mang da sap xep).
    
    //swapCount = 0; //Bien toan cuc de dem so lan hoan doi
    static void InsertSort(int[] arr)
    {
        
    }
}
