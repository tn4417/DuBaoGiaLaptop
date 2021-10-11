using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuBaoGiaLaptop
{
    public class chuanHoa
    {
        XuLyConnect xlcnn = new XuLyConnect();

        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LAPTOPConnectionString"].ConnectionString.ToString());

        public double MaxRecord(string column)
        {
            try
            {
                conn.Open();
                string sql = "SELECT MAX(" + column + ") FROM laptops";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }

        public double MinRecord(string column)
        {
            try
            {
                conn.Open();
                string sql = "SELECT MIN(" + column + ") FROM laptops";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public double ValueRecord(string column_code, string column, string id)
        {
            try
            {
                conn.Open();
                string sql = "select " + column_code + " from laptops where " + column + "='" + id + "' group by " + column_code;
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public double chuanHoaColumn(double columnValue, double max, double min)
        {
            return (columnValue - min) / (max - min);
        }

    }
}

