using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 50;
        public static int TableHeight = 50;
        private TableDAO() { }
        // Methods for TableDAO will be added here in the future

        public List<Table> LoadTableList()
        {
            // Code to load tables will be implemented here'
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow row in data.Rows) {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
