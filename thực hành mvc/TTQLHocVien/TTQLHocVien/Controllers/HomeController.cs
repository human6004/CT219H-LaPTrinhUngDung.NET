using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTQLHocVien.Models;

namespace TTQLHocVien.Controllers
{
    public class HomeController : Controller
    {
        DBIO db = new DBIO();  //mục đích của tạo đối tượng db là để gọi dùng các method của nó 

        // GET: Home 
        public ActionResult Index()
        {
            List<HOCVIEN> list = db.getList_HocVien(); //trả về một danh sách 
            return View(list);
        }

        //Không dùng tham số gì cả cho Create() 
        public ActionResult Create()
        {
            return View();
        }

        //Khi gọi đến phương thức addObject_SACH(SACH s) in DBIO.cs 
        //thì đồng thời ta cần một thông điệp nào đó để nó load dữ liệu lên 
        //=> dùng [HttpPost] 
        [HttpPost]
        public ActionResult Create(HOCVIEN s)
        {
            db.addObject_HocVien(s);
            //sau khi thêm rồi, ta điều hướng người dùng đến trang Index 
            return RedirectToAction("Index");
        }

        //Sửa sách phức tạp hơn thêm (create) vì ta cần biết sửa sách nào?  
        //Ta cần biết id của quyển sách bạn đang định sửa 
        public ActionResult Edit(string id)
        {
            HOCVIEN s = db.getObject_HocVien(id);
            return View(s);   //lấy ra quyển sách thì sau đó mới sửa được 
        }

        [HttpPost] //Ý nghĩa là khi bạn gọi Edit nó cần gửi lên thông điệp để sửa thông tin này  
        public ActionResult Edit(HOCVIEN s) //phải đặt tên là Edit như hàm bên trên, không dùng tên khác 
        {
            db.editObject_HocVien(s);
            return RedirectToAction("Index"); //Khi sửa rồi thì hệ thống sẽ điều hướng quay về trang chủ 
        }

        //Xóa một quyển sách 
        //Ta cần biết id của quyển sách bạn đang định xóa 
        public ActionResult Delete(string id)
        {
            HOCVIEN s = db.getObject_HocVien(id);
            return View(s);   //lấy ra quyển sách thì sau đó mới xóa được 
        }

        [HttpPost] //Ý nghĩa là khi bạn gọi Delete nó cần gửi lên thông điệp để xóa thông tin này  
        public ActionResult Delete(HOCVIEN s)
        {
            db.deleteObject_HocVien(s);
            return RedirectToAction("Index"); //Khi xóa rồi thì hệ thống sẽ điều hướng quay về trang chủ 
        }

        //Xem một quyển sách 
        //Ta cần biết id của quyển sách bạn đang định xem chi tiết 
        public ActionResult Details(string id)
        {
            HOCVIEN s = db.getObject_HocVien(id);
            return View(s);   //lấy ra quyển sách cần xem 
        }
        
    }
}