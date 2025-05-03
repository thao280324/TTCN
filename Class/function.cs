using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace thutap.Class
{
    internal class function
    {
        public static SqlConnection Conn;
        public static string connstring;
        public static void Connect()
        {
            connstring = "Data Source=DESKTOP-IK88KCU;Initial Catalog=thuvien;Integrated Security=True;TrustServerCertificate=True";
            Conn = new SqlConnection();
            Conn.ConnectionString = connstring;
            Conn.Open();
            // MessageBox.Show("Done");
        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            //Kiểm tra kết nối, nếu chưa kết nối thì thực hiện kết nối
    if (function.Conn == null)
            {
                function.Conn = new SqlConnection("Data Source=DESKTOP-IK88KCU;Initial Catalog=thuvien;Integrated Security=True;TrustServerCertificate=True;");
            }

            // Kiểm tra nếu kết nối chưa mở thì mở kết nối
            if (function.Conn.State == ConnectionState.Closed)
            {
                function.Conn.Open();
            }

            // Tạo đối tượng SqlDataAdapter
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, function.Conn);

            // Tạo bảng DataTable để lưu trữ dữ liệu từ SQL query
            DataTable table = new DataTable();

            // Điền dữ liệu vào DataTable từ SqlDataAdapter
            Mydata.Fill(table);

            // Trả về DataTable
            return table;


        }
        public static void RunSql(string sql, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            try
            {
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
        }
        public static void FillCombo2(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ma;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Class.function.Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            // yyyy-MM-dd  
            string dt = String.Format("{0}-{1}-{2}", parts[2], parts[1], parts[0]);
            return dt;
        }
        public static double? GetFieldValues1(string sql)
        {
            double? ma = null;
            SqlCommand cmd = new SqlCommand(sql, function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    ma = reader.GetDouble(0);
                }
            }

            reader.Close();
            return ma;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public static List<string> GetFieldValuesMultiple(string sql)
        {
            List<string> values = new List<string>();
            SqlCommand cmd = new SqlCommand(sql, function.Conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Lấy tất cả các giá trị trong dòng, bạn có thể thay đổi chỉ số GetValue tùy vào số lượng cột
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    values.Add(reader.GetValue(i).ToString());
                }
            }

            reader.Close();
            return values;
        }
        public static string GetFieldValuesWithParams(string sql, params SqlParameter[] parameters)
        {
            string result = "";
            using (SqlCommand cmd = new SqlCommand(sql, function.Conn))
            {
                cmd.Parameters.AddRange(parameters);

                try
                {
                    function.Conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
                finally
                {
                    function.Conn.Close();
                }
            }
            return result;
        }


    }
}
