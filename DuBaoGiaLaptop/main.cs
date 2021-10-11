using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuBaoGiaLaptop
{
    public partial class main : Form
    {
        XuLyConnect xl = new XuLyConnect();
        public frm_DuBao frm_DB = null;



        public main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_DB_LAPTOP.Tables["laptops"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xl.txtDataBinding(txt_brands, "brands", dataGridView1);
            xl.txtDataBinding(txt_chip_brands, "chip_brands", dataGridView1);
            xl.txtDataBinding(txt_chip_speed, "chip_speed", dataGridView1);
            xl.txtDataBinding(txt_chip_type, "chip_type", dataGridView1);
            xl.txtDataBinding(txt_graphic_card_brand, "graphic_card_brand", dataGridView1);
            xl.txtDataBinding(txt_graphic_card_model, "graphic_card_model", dataGridView1);
            xl.txtDataBinding(txt_HDD, "HDD", dataGridView1);
            xl.txtDataBinding(txt_monitorSize, "monitorSize", dataGridView1);
            xl.txtDataBinding(txt_product_name, "product_name", dataGridView1);
            xl.txtDataBinding(txt_ram, "ram", dataGridView1);
            xl.txtDataBinding(txt_SSD, "SSD", dataGridView1);
            xl.txtDataBinding(txt_price, "price", dataGridView1);
        }

        private void txt_HDD_BindingContextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "0") t.Text = "Không có";
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            frm_DB = new frm_DuBao();
            frm_DB.ShowDialog();
        }

    }
}
