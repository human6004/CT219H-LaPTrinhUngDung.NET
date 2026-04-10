//internal class Bien
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


//  Ví dụ 1.1: Khởi tạo và gán giá trị một biến 
//class Bien
//{
//    static void Main()
//    {
//        // Khai bao va khoi tao bien 
//        int bien = 9;
//        System.Console.WriteLine("Sau khi khoi tao: bien = {0}", bien);
//        // Gan gia tri cho bien 
//        bien = 5;
//        // Xuat ra man hinh 
//        System.Console.WriteLine("Sau khi gan: bien = {0}", bien);
//    }
//}

//Ví dụ 1.2: Nhập vào bán kính, in ra chu vi và diện tích hình tròn. 
//class HinhTron
//{
//    static void Main()
//    {
//        // Khai bao bieu tuong hang 
//        const double PI = 3.14159;
//        // Khai bao bien 
//        int bankinh;
//        double chuvi, dientich;
//        string chuoi;
//        // Nhap gia tri cho bien chuoi 
//        Console.Write("Nhap ban kinh hinh tron: ");
//        chuoi = Console.ReadLine();
//        // Doi chuoi thanh so va gan vao bien so 
//        bankinh = Convert.ToInt32(chuoi);
//        // Gan gia tri cho bien 
//        chuvi = 2 * bankinh * PI;
//        dientich = bankinh * bankinh * PI;
//        // Xuat ra man hinh 
//        Console.WriteLine("Chu vi hinh tron = {0:0.00}", chuvi);
//        Console.WriteLine("Dien tich hinh tron = {0:0.00}", dientich);
//    }
//}


//Ví dụ 1.3:
//class ChaoMung { 
//    static void Main()
//    {
//        // xuất ra màn hình thông báo chuỗi thong bao 'Chao mung ban den voi C# 2008 '
//        Console.WriteLine("Chao mung ban den voi C# 2008 ");
//        Console.ReadLine();

//    }
//}

//Ví dụ 1.4: Nhập vào họ và tên, in ra màn hình họ tên bằng chữ IN HOA, chữ thường, độdài của họ và tên.
//class HoTen
//{
//    static void Main()
//    {
//        // khai báo biến
//        string hoTen;
//        // nhập giá trị cho biến
//        Console.Write("Nhap ho va ten cua ban: ");
//        hoTen = Console.ReadLine();
//        // thao tác trên chuỗi
//        string hoTenInHoa = hoTen.ToUpper();
//        string hoTenInThuong = hoTen.ToLower();
//        int doDaiHoTen = hoTen.Length;
//        // xuất ra màn hình
//        Console.WriteLine("Ho va ten in hoa: {0}", hoTenInHoa);
//        Console.WriteLine("Ho va ten in thuong: {0}", hoTenInThuong);
//        Console.WriteLine("Do dai cua ho va ten: {0}", doDaiHoTen);
//    }
//}

//Ví dụ 2.1: Dùng câu lệnh điều kiện if … else
//class Chan_Le
//{
//    static void Main()
//    {
//        // Khai bao va khoi tao bien
//        int bienDem = 9;
//        // Xuat ra man hinh
//        if (bienDem % 2 == 0)
//            Console.WriteLine("{0} la so chan", bienDem);
//        else Console.WriteLine("{0} la so le", bienDem);
//    }
//}

// ---------------------------bài 2--------------------------
// câu 1
//class soNguyen
//{
//    static void Main()
//    {
//        int a,b, c;
//        Console.Write("Nhap so nguyen a: ");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Nhap so nguyen b: ");
//        b = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Nhap so nguyen c: ");
//        c = Convert.ToInt32(Console.ReadLine());
//        if (a > b && a > c)
//        {
//            Console.WriteLine("So lon nhat la: {0}", a);
//        }
//        else if (b > a && b > c)
//        {
//            Console.WriteLine("So lon nhat la: {0}", b);
//        }
//        else
//        {
//            Console.WriteLine("So lon nhat la: {0}", c);
//        }

//    }
//}

// câu 2
//class hocSinh
//{
//     static void Main()
//    {
//        string hoTen;
//        double diemCK;
//        Console.Write("Nhap ho va ten hoc sinh: ");
//        hoTen = Console.ReadLine();
//        Console.Write("Nhap diem cuoi ky: ");
//        diemCK = Convert.ToDouble(Console.ReadLine());
//        if (diemCK >= 8)
//        {
//            Console.WriteLine("Hoc sinh {0} xep loai Gioi", hoTen); 
//        }
//        else if(diemCK >= 6.5)
//        {
//            Console.WriteLine("Hoc sinh {0} xep loai Kha", hoTen);
//        }
//        else if(diemCK >= 5)
//        {
//            Console.WriteLine("Hoc sinh {0} xep loai Trung Binh", hoTen);
//        }
//        else
//        {
//            Console.WriteLine("Hoc sinh {0} xep loai Yeu", hoTen);
//        }
//    }
//}

//// câu 3
//class phuongTrinhBacMot
//{
//    static void Main()
//    {
//        double a, b;
//        Console.Write("Nhap he so a: ");
//        a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nhap he so b: ");
//        b = Convert.ToDouble(Console.ReadLine());
//        if (a == 0)
//        {
//            if (b == 0)
//            {
//                Console.WriteLine("Phuong trinh vo so nghiem");
//            }
//            else
//            {
//                Console.WriteLine("Phuong trinh vo nghiem");
//            }
//        }
//        else
//        {
//            double x = -b / a;
//            Console.WriteLine("Phuong trinh co nghiem x = {0}", x);
//        }
//    }
//}

//câu 4
//class phuongTrinhBacHai
//{
//    static void Main()
//    {
//        double a, b, c;
//        Console.Write("Nhap he so a: ");
//        a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nhap he so b: ");
//        b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Nhap he so c: ");
//        c = Convert.ToDouble(Console.ReadLine());
//        double delta = b * b - 4 * a * c;
//        if (delta < 0)
//        {
//            Console.WriteLine("Phuong trinh vo nghiem");
//        }
//        else if (delta == 0)
//        {
//            double x = -b / (2 * a);
//            Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", x);
//        }
//        else
//        {
//            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
//            Console.WriteLine("x1 = {0}", x1);
//            Console.WriteLine("x2 = {0}", x2);
//        }
//    }
//}

// câu 5 Viết chương trình nhập vào một số nguyên cho đến khi nhận được số nguyên dương thì dừng
//class soNguyenDuong
//    {
//    static void Main()
//    {
//        int soNguyen;
//        do
//        {
//            Console.Write("Nhap vao mot so nguyen duong: ");
//            soNguyen = Convert.ToInt32(Console.ReadLine());
//        }while (soNguyen <= 0);
//        Console.WriteLine("Ban da nhap so nguyen duong: {0}", soNguyen);
//    }
//}

//câu 6 Viết chương trình nhập vào một số nguyên n. Cho biết số nguyên n có phải là số nguyêntố không 
//class soNguyenTo
//{
//    static void Main()
//    {
//        int n;
//        Console.Write("Nhap vao mot so nguyen: ");
//        n = Convert.ToInt32(Console.ReadLine());
//        if (n < 2)
//        {
//            Console.WriteLine("{0} khong phai la so nguyen to", n);
//            return;
//        }
//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//            {
//                Console.WriteLine("{0} khong phai la so nguyen to", n);
//                return;
//            }
//        }
//        Console.WriteLine("{0} la so nguyen to", n);
//    }
//}

//câu 7 Viết chương trình nhập vào một số nguyên dương n chỉ năm dương lịch. Cho biết n có phải là năm nhuận không ?
//class namNhuan
//{
//    static void Main()
//    {
//        int n;
//        Console.Write("Nhap vao mot nam duong lich: ");
//        n = Convert.ToInt32(Console.ReadLine());
//        if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
//        {
//            Console.WriteLine("{0} la nam nhuan", n);
//        }
//        else
//        {
//            Console.WriteLine("{0} khong phai la nam nhuan", n);
//        }
//    }
//}

// câu 9 
class inSoNguyen()
{
    static void Main() {
        int n;
        Console.Write("nhập vào số dương: ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
 }