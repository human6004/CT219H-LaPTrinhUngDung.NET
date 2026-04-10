using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTQLHocVien.Models
{
    public class DBIO
    {
        QLHocVienEntities mydb = new QLHocVienEntities();

        //hàm getList_SACH() để thực hiện một câu truy vấn 
        //trả về một danh sách dùng iQuery 
        public List<HOCVIEN> getList_HocVien()
        {
            //access to the SACH table to read all rows 
            return mydb.HOCVIEN.ToList();
        }

        //hàm getObject_SACH(string id) trả về một quyển sách theo id  
        public HOCVIEN getObject_HocVien(string id)
        {
            //biểu thức so sánh có cú pháp như C# 
            //chứ không phải của SQL 
            return mydb.HOCVIEN.Where(c => c.MAHOCVIEN == id).FirstOrDefault();
        }

        //hàm addObject_SACH(SACH s) thêm vào một quyển sách 
        public void addObject_HocVien(HOCVIEN s)
        {
            mydb.HOCVIEN.Add(s);
            mydb.SaveChanges();
        }

        //hàm editObject_SACH(SACH s) sửa một quyển sách 
        public void editObject_HocVien(HOCVIEN s)
        {
            HOCVIEN x = getObject_HocVien(s.MAHOCVIEN);
            x.TENHOCVIEN = s.TENHOCVIEN;
            x.NGAYSINH = s.NGAYSINH;
            x.EMAIL = s.EMAIL;
            x.DIENTHOAI = s.DIENTHOAI;
            x.PROFILE = s.PROFILE;
            mydb.SaveChanges();
        }

        //hàm deleteObject_SACH(SACH s) xóa một quyển sách s 
        public void deleteObject_HocVien(HOCVIEN s)
        {
            HOCVIEN x = getObject_HocVien(s.MAHOCVIEN);
            mydb.HOCVIEN.Remove(x);
            mydb.SaveChanges();
        }
    }
}