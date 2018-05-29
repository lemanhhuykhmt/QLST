using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLST.ExtendModel
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        private DataProvider() { }
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameters[i++]);
                    }
                }
            }
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }//thực hiệnc các câu lệnh trả về bảng
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameters[i++]);
                    }
                }
            }
            data = command.ExecuteNonQuery();
            connection.Close();
            return data;
        }// thực hiện lệnh update, insert, delete, trả về số dòng thay đổi
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameters[i++]);
                    }
                }
            }
            data = command.ExecuteScalar();
            connection.Close();
            return data;
        }// thực hiện lệnh trả về giá trị 1 ô trên cùng bên trái
    }
}
