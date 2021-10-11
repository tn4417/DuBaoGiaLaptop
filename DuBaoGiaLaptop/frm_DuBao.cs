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
    public partial class frm_DuBao : Form
    {
        XuLyConnect xl = new XuLyConnect();

        chuanHoa ch = new chuanHoa();

        private DataTable dt;



        double maxRam, minRam, max_brands_code, min_brands_code;
        double max_chip_type_code, min_chip_type_code, max_hdd, min_hdd, max_ssd, min_ssd;
        double max_graphic_card_model_code, min_graphic_card_model_code;
        double max_monitorSize, min_monitorSize, max_price, min_price;

        public frm_DuBao()
        {
            InitializeComponent();

        }

        private void frm_DuBao_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = xl.Ds_DB_LAPTOP.Tables["laptops"];


            cmb_brands.DisplayMember = "brands";
            cmb_chip_brands.DisplayMember = "chip_brands";
            cmb_chip_type.DisplayMember = "chip_type";
            cmb_graphic_card_brand.DisplayMember = "graphic_card_brand";
            cmb_graphic_card_model.DisplayMember = "graphic_card_model";
            cmb_HDD.DisplayMember = "HDD";
            cmb_monitorSize.DisplayMember = "monitorSize";
            cmb_ram.DisplayMember = "ram";
            cmb_SSD.DisplayMember = "SSD";

            cmb_brands.DataSource = xl.LoadComboBox("laptops", "brands");
            cmb_chip_brands.DataSource = xl.LoadComboBox("laptops", "chip_brands");
            cmb_graphic_card_brand.DataSource = xl.LoadComboBox("laptops", "graphic_card_brand");
            cmb_HDD.DataSource = xl.LoadComboBox("laptops", "HDD");
            cmb_monitorSize.DataSource = xl.LoadComboBox("laptops", "monitorSize");
            cmb_ram.DataSource = xl.LoadComboBox("laptops", "ram");
            cmb_SSD.DataSource = xl.LoadComboBox("laptops", "SSD");

            maxRam = ch.MaxRecord("ram");
            minRam = ch.MinRecord("ram");
            max_brands_code = ch.MaxRecord("brands_code");
            min_brands_code = ch.MinRecord("brands_code");
            max_chip_type_code = ch.MaxRecord("chip_type_code");
            min_chip_type_code = ch.MinRecord("chip_type_code");
            max_hdd = ch.MaxRecord("hdd");
            min_hdd = ch.MinRecord("hdd");
            max_ssd = ch.MaxRecord("ssd");
            min_ssd = ch.MinRecord("ssd");
            max_graphic_card_model_code = ch.MaxRecord("graphic_card_model_code");
            min_graphic_card_model_code = ch.MinRecord("graphic_card_model_code");
            max_monitorSize = ch.MaxRecord("monitorSize");
            min_monitorSize = ch.MinRecord("monitorSize");
            max_price = ch.MaxRecord("price");
            min_price = ch.MinRecord("price");
        }

        private void cmb_chip_brands_TextChanged(object sender, EventArgs e)
        {
            cmb_chip_type.DataSource = xl.LoadComboBoxByBrands("laptops", "chip_type", cmb_chip_brands.Text, "chip_brands");
        }

        private void cmb_graphic_card_brand_TextChanged(object sender, EventArgs e)
        {
            cmb_graphic_card_model.DataSource = xl.LoadComboBoxByBrands("laptops", "graphic_card_model", cmb_graphic_card_brand.Text, "graphic_card_brand");
        }

        private void cmb_brands_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            xuly();
        }

        public double powr2(double valueSelected, double valueR)
        {
            return Math.Pow(valueSelected - valueR, 2);
        }

        public void xuly()
        {
            txt_GiaBQuan.Clear();
            txt_GiaMax.Clear();
            txt_GiaMin.Clear();

            double brands = ch.chuanHoaColumn(ch.ValueRecord("brands_code", "brands", cmb_brands.Text), max_brands_code, min_brands_code);
            double chip_type = ch.chuanHoaColumn(ch.ValueRecord("chip_type_code", "chip_type", cmb_chip_type.Text), max_chip_type_code, min_chip_type_code);
            double graphic_card_model = ch.chuanHoaColumn(ch.ValueRecord("graphic_card_model_code", "graphic_card_model", cmb_graphic_card_model.Text), max_graphic_card_model_code, min_graphic_card_model_code);
            double _ram = ch.chuanHoaColumn(Convert.ToDouble(cmb_ram.Text), maxRam, minRam);
            double _ssd = ch.chuanHoaColumn(Convert.ToDouble(cmb_SSD.Text), max_ssd, min_ssd);
            double _hdd = ch.chuanHoaColumn(Convert.ToDouble(cmb_HDD.Text), max_hdd, min_hdd);
            double monitor = ch.chuanHoaColumn(Convert.ToDouble(cmb_monitorSize.Text), max_monitorSize, min_monitorSize);

            List<BaoGia> lst = new List<BaoGia>();
            foreach (DataRow row in dt.Rows)
            {
                double brandsr = ch.chuanHoaColumn((double)row["brands_code"], max_brands_code, min_brands_code);
                double chip_typer = ch.chuanHoaColumn((double)row["chip_type_code"], max_chip_type_code, min_chip_type_code);
                double graphic_card_modelr = ch.chuanHoaColumn((double)row["graphic_card_model_code"], max_graphic_card_model_code, min_graphic_card_model_code);
                double _ramr = ch.chuanHoaColumn((double)row["ram"], maxRam, minRam);
                double _ssdr = ch.chuanHoaColumn((double)row["ssd"], max_ssd, min_ssd);
                double _hddr = ch.chuanHoaColumn((double)row["hdd"], max_hdd, min_hdd);
                double monitorr = ch.chuanHoaColumn((double)row["monitorSize"], max_monitorSize, min_monitorSize);
                double pricer = (double)row["price"];
                double kc = powr2(brands, brandsr) + powr2(chip_typer, chip_type) + powr2(graphic_card_model, graphic_card_modelr)
                            + powr2(_ram, _ramr) + powr2(_ssd, _ssdr) + powr2(_hdd, _hddr) + powr2(monitor, monitorr);
                double kc2 = Math.Sqrt(kc);
                BaoGia baogia = new BaoGia(kc2, pricer);
                lst.Add(baogia);
            }
            var lstSorted = lst.OrderBy(p => p.KhoangCach);
            var lstTake = lstSorted.Take(7);
            var max = lstTake.Max(p => p.Gia);
            var min = lstTake.Min(p => p.Gia);
            var sum = lstTake.Sum(p => p.Gia);
            double gia2 = sum / 7;
            txt_GiaMax.Text = string.Format("{0:0,0 VND}", max * 1000);
            txt_GiaMin.Text = string.Format("{0:0,0 VND}", min * 1000);
            txt_GiaBQuan.Text = string.Format("{0:0,0 VND}", gia2 * 1000);
            lst = null;
            return;
        }


    }
}
