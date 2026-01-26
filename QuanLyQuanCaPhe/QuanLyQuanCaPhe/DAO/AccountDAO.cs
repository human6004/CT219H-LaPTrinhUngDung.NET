using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
            {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            // code đăng nhập sẽ viết ở đây
            //string query = "select * from Account where UserName = N'" + username + "' and PassWord = N'" + password + "'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);
            //if (result.Rows.Count > 0)
            //    return true;

            //return false;

            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

    }
}
