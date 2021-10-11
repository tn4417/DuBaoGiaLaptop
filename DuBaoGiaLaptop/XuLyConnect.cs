using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuBaoGiaLaptop
{
    public class XuLyConnect
    {

        #region KhaiBao&LoadData
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LAPTOPConnectionString"].ConnectionString.ToString());

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        private DataSet ds_DB_LAPTOP = new DataSet();

        public DataSet Ds_DB_LAPTOP
        {
            get { return ds_DB_LAPTOP; }
            set { ds_DB_LAPTOP = value; }
        }

        SqlDataAdapter laptops = null;

        public SqlDataAdapter Laptops
        {
            get { return laptops; }
            set { laptops = value; }
        }

        public XuLyConnect()
        {
            laptops = addTable("laptops");
        }


        public SqlDataAdapter addTable(string tb)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from " + tb, conn);
                da.Fill(ds_DB_LAPTOP, tb);

                return da;
            }
            catch { return null; }
        }

        public void clearTXT(Control item)
        {
            if (item.GetType() == typeof(RadioButton))
            {
                RadioButton rdb = (RadioButton)item;
                rdb.DataBindings.Clear();
                rdb.Checked = false;
                return;
            }
            else if (item.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)item;
                txt.DataBindings.Clear();
                txt.Text = null;
                return;
            }
            foreach (Control it in item.Controls)
            {
                clearTXT(it);
            }
        }

        public void txtDataBinding(TextBox t, string column, DataGridView dgv)
        {
            t.DataBindings.Clear();
            t.DataBindings.Add("Text", dgv.DataSource, column);
        }

        public string convrtDateTime(string date)
        {
            DateTime d = new DateTime();
            d = Convert.ToDateTime(date);
            return d.ToLongDateString();
        }
        #endregion

        public bool commitChanged(SqlDataAdapter da, string tb)
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(ds_DB_LAPTOP, tb);
                return true;
            }
            catch { return false; }
        }

        public DataTable LoadComboBox(string tb, string column)
        {
            SqlDataAdapter da = new SqlDataAdapter("select " + column + " from " + tb + " group by " + column, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LoadComboBoxByBrands(string tb, string column, string where, string brands)
        {
            SqlDataAdapter da = new SqlDataAdapter("select " + column + " from " + tb + " where " + brands + " ='" + where + "' group by " + column, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
