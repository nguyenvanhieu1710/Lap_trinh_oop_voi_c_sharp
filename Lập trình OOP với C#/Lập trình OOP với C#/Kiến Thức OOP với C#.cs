using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lập_trình_OOP_với_C_
{
    //Bài 2:Cách sử dụng class
    /*
    class Cat
    {
        public double Weight;
        public double Height;        
         //   Constructor không có tham số
        public Cat()
        {
            Weight = 800;
            Height = 10;
        }      
        //    Constructor có tham số         
        public Cat(int w, int h)
        {

            Weight = w;
            Height = h;

        }
        public void Info()
        {
            Console.WriteLine(" Height: " + Height + " Weight: " + Weight);
        }
        static void Main()
        {
            
            //    Để ý khi bạn new Cat bạn không truyền tham số vào thì constructor mặc định (constructor không tham số)
            // sẽ tự động được gọi để khởi tạo các giá trị mặc định cho các thuộc tính của đối tượng BlackCat.

            
            Cat BlackCat = new Cat();

            BlackCat.Info(); // In ra thông tin Weight, Height có thực sự được khởi tạo giá trị chưa.

            //    Lần này ta khởi tạo đối tượng và có truyền 2 tham số như vậy constructor có tham số sẽ được gọi.
            //    Như vậy các thuộc tính Weight, Height sẽ không mang giá trị mặc định nữa mà sẽ được gán theo giá trị mà người dùng
            // truyền vào.
            

            Cat WhiteCat = new Cat(1200, 30);
            WhiteCat.Info(); // In ra thông tin Weight, Height để xem có theo mong muốn chưa.
        }
    }
    */

    //Bài 3:Cách sử dụng get,set(Phương thức truy vấn,Phương thức cập nhật)
    /*
    class SinhVien
    {        
           // Các thuộc tính đều mang phạm vi là private. Vì thế chỉ được sử dụng nội bộ trong class
            //Ra bên ngoài sẽ không truy cập được.
        private string MASV;
        private string HoTen;//có thể dùng Ctrl+R+E để chuyển từ private thành public cho nhanh
        private double DiemToan;
        private double DiemVan;

        //VD:public string HoTen1 { get => HoTen2; set => HoTen2 = value; }

        //Phương thức này có phạm vi là public nên có sử dụng từ bên ngoài.
        //Và vì phương thức này nằm trong lớp nên có thể sử dụng các thuộc tính private ở trên.        
        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;
            Console.WriteLine(" Sinh vien " + HoTen1 + " co diem TB la: " + DTB);
        }
        static void Main()
        {
            SinhVien sv = new SinhVien();
            sv.InThongTinDiemTB();
        }
    }
    */
    /*
    static void Main()
    {
        SinhVien sv = new SinhVien();//Rõ ràng các thuộc tính đều đã ẩn đi và không thể truy cập chỉ còn lại các thành phần public.
        sv.InThongTinDiemTB();
    }
    */
    /*
    class Sinhvien
    {
       // Đây là thay đổi phạm vi từ private thành public
        private double diemLy;
        public double DiemLy
        {
            get { return diemLy; }
            set
            {                
                // Kiểm tra điểm lý có thoả mãn hay không
                //Nếu có sẽ thực hiện gán vào thuộc tính private.
                // Nếu không sẽ không làm gì cả.
                // Điều này nhằm đảm bào tính đúng đắn của dữ liệu.                
                if (value <= 10 || value >= 0)
                {
                    diemLy = value;
                }
            }
        }

    }
    */


}
