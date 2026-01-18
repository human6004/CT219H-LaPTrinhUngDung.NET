using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    internal class DataProvider
    {
       private string connectionSTR =
            @"Server=NHAN\SQLEXPRESS;
                Database=QuanLyQuanCafe;
                Integrated Security=True;
                TrustServerCertificate=True;";


        //trả về bảng dữ liệu
        //thực thi các câu lệnh select
        public DataTable ExecuteQuery(string query, Object[] paramecter = null)
        {
            DataTable data = new DataTable();

            //mo ket noi
            //cho dù vấn đề gì xảy ra thì kết nối vẫn được đóng lại(tự giải phóng bộ nhớ )
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);
                if(paramecter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramecter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;

        }




        //trả về số dòng bị ảnh hưởng
        //thực thi các câu lệnh insert, update, delete
        public int ExecuteNonQuery(string query, Object[] paramecter = null)
        {
            //DataTable data = new DataTable();
            int data = 0;

            //mo ket noi
            //cho dù vấn đề gì xảy ra thì kết nối vẫn được đóng lại(tự giải phóng bộ nhớ )
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);
                if (paramecter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramecter[i]);
                            i++;
                        }
                    }
                }

                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.Fill(data);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;

        }



        //trả về số dòng bị ảnh hưởng
        //số lương trả ra 
        public object ExecuteScalar(string query, Object[] paramecter = null)
        {
            //DataTable data = new DataTable();
            object data = 0;

            //mo ket noi
            //cho dù vấn đề gì xảy ra thì kết nối vẫn được đóng lại(tự giải phóng bộ nhớ )
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                //command.Parameters.AddWithValue("@userName", id);
                if (paramecter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramecter[i]);
                            i++;
                        }
                    }
                }

                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.Fill(data);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;

        }
    }
}
    