using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thutap.Class
{
     class Functions
    {
        //public static SqlConnection conn;
        //public static string connectionString;

        //public static void Connect()
        //{
        //connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;Encrypt=False";
        //conn = new SqlConnection();
        //conn.ConnectionString = connectionString;
        //conn.Open();
        //MessageBox.Show("Ket noi thanh cong");
        //}
        private static readonly string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;Encrypt=False";
        public static DataTable GetdatatoTable(string sql)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter myData = new SqlDataAdapter();
                myData.SelectCommand = new SqlCommand();
                myData.SelectCommand.Connection = connection;
                myData.SelectCommand.CommandText = sql;
                DataTable table = new DataTable();
                myData.Fill(table);
                return table;
            } // Kết nối tự động đóng tại đây
        }
        public static bool checkkey(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter myData = new SqlDataAdapter())
                {
                    myData.SelectCommand = new SqlCommand(sql, connection);
                    if (parameters != null)
                    {
                        myData.SelectCommand.Parameters.AddRange(parameters);
                    }
                    DataTable table = new DataTable();
                    myData.Fill(table);
                    return table.Rows.Count > 0;
                }
            }
        }
        public static void RunSql(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw; // Ném lại ngoại lệ để caller có thể xử lý nếu cần
                    }
                }
            }
        }
        public static void RunSqlDel(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if (parts.Length != 3) return false;
            if (int.TryParse(parts[0], out int day) && int.TryParse(parts[1], out int month) && int.TryParse(parts[2], out int year))
            {
                return (day >= 1) && (month >= 1) && (month <= 12) && (year >= 1900);
            }
            return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = string.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter myData = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                myData.Fill(table);
                cbo.DataSource = table;
                cbo.ValueMember = ma;
                cbo.DisplayMember = ten;
            }
        }
        public static string GetFieldValues(string sql, params SqlParameter[] parameters)
        {
            string ma = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ma = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return ma;
        }

    }
}
