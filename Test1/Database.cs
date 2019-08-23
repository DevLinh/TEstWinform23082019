using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    
    class Database
    {
        SqlConnection sqlCon; // Khởi tạo đối tượng kết nối
        SqlDataAdapter da; // Khởi tạo bộ điều phối dữ liệu
        DataSet ds; // Khởi tạo đối tượng chứa dữ liệu khi giao tiếp

        public Database()
        {
            string strConn = "Data source = PC157\\SQLEXPRESS; database = QLSinhvien; Integrated Security = true";
            sqlCon = new SqlConnection(strConn);
        }
            
        // Khởi tạo phương thức thực hiện truy vấn dữ liệu trả về datatable
        public DataTable Excute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlCon);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        // Khởi tạo phương thức truy vấn không trả về
        public void ExcuteNonQuery(string sqlStr)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, sqlCon);
            sqlCon.Open(); // Mở kết nối
            cmd.ExecuteNonQuery(); // Thực thi
            sqlCon.Close();
        }



    }
}
