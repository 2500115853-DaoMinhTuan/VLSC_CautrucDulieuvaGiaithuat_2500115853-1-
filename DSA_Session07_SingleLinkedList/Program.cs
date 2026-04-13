using System;

namespace DSA_Session07_SingleLinkedList
{
    //1. DINH NGHIA CLASS NODE: MOT MAT XICH TRONG DANH SACH
    public class Node
    {
        public int Data; //DU LIEU CUA MAT XICH
        public Node Next; //"Soi day" tro den mat xich tiep theo

        //Constructor: Khoi tao gia tri khi tao Node moi
        public Node(int data)
        {
            Data = data;
            Next = null; //Mac dinh sinh ra chua noi voi ai ca
        }
    }

    //2. DINH NGHIA CLASS SINGLE LINKED LIST: DANH SACH LIEN KET DON
    public class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            head = null;
        }

        //3. PHUONG THUC THEM MAT XICH VAO CUOI DANH SACH
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        //4. PHUONG THUC IN RA DANH SACH
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        //8.1 Viet ham dem va tra ve tong so luong Node dang co trong danh sach
        public int CountNodes()
        {
            int count = 0; //Bien dem so luong Node
            Node current = head; //Bat dau tu Node dau tien
            while (current != null)
            {
                count++; //Tang bien dem khi gap mot Node
                current = current.Next; //Di chuyen den Node tiep theo
            }
            return count; //Tra ve tong so luong Node
        }

    //8.2 Tim xem mot so target co ton tai trong danh sach hay khong.
    //(Goi y: Tra ve true hoac false)
    public bool Search(int target)
        {
            Node current = head;
            while (current != null)
            {
                if(current.Data == target)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

    //8.3 Xoa phan tu o dau danh sach (Goi ý: Cuc ky don gian,
    //chi can cho Head)
    public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }

    //8.4 Xoa Node dau tien co Data bang voi gia tri value
    public void DeleteByValue(int value)
        {
            if (head == null)
            {
                return;
            }
            if (head.Data == value)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

    //5. CHUONG TRINH CHINH: TEST DANH SACH LIEN KET DON
    class Program
    {
        static void Main(string[] args)
        {
            //Tao mot instance cua SingleLinkedList de quan ly danh sach
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Chao mung den voi danh sach lien ket don!");
            
            //tao menu de nguoi dung chon thao tac
            while (true)
            {
                Console.WriteLine("\nVui long chon thao tac:");
                Console.WriteLine("1. Them mat xich vao cuoi danh sach");
                Console.WriteLine("2. In ra danh sach");
                Console.WriteLine("3. Xoa danh sach");
                Console.WriteLine("4. Dem so luong Node (Test ham moi)"); // Thêm menu để test hàm CountNodes
                Console.WriteLine("5. Thoat");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhap du lieu cho mat xich moi: ");
                        int data = int.Parse(Console.ReadLine());
                        list.AddLast(data);
                        break;
                    case "2":
                        list.PrintList();
                        break;
                    case "3":
                        list = new SingleLinkedList();
                        Console.WriteLine("Danh sach da duoc xoa.");
                        break;
                    case "4":
                        // Gọi hàm đếm số lượng Node
                        int totalNodes = list.CountNodes();
                        Console.WriteLine("Tong so luong Node hien co la: " + totalNodes);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}
}