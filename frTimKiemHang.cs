using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLBanHangDienTu
{
    public partial class frTimKiemHang : Form
    {
        public frTimKiemHang()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable data = BLL_getData.getTable("pro_getAllHangHoa");
            int up = 0;
            IEnumerable<DataRow> result = data.AsEnumerable().Where(r =>
            (cbbManhom.SelectedIndex == -1 ? true :
            r.Field<string>("Manhom").Contains(cbbManhom.SelectedValue.ToString()))
            &&
            (cbbMaloai.SelectedIndex == -1 ? true :
            r.Field<string>("Maloai").Contains(cbbMaloai.SelectedValue.ToString()))
            &&
            (int.TryParse(txtThoigianbaohanh.Text, out up) == false ? true :
            r.Field<int>("Thoigianbaohanh") == int.Parse(txtThoigianbaohanh.Text)));

            try
            {
                DataTable t = result.CopyToDataTable();
                dataGridView1.DataSource = t;
                dataGridView1.Refresh();
            }
            catch (Exception) { }
        }

        DataTable tbnhom, tbloai;
        private void fillAllCbb()
        {
            tbnhom = BLL_getData.getTable("pro_getAllNhom");
            fillComboBox(tbnhom, cbbManhom, "Manhom", "Tennhom");
            tbloai = BLL_getData.getTable("pro_getAllLoai");
            fillComboBox(tbloai, cbbMaloai, "Maloai", "Tenloai");

        }

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void cbbManhom_DropDown(object sender, EventArgs e)
        {
            tbnhom = BLL_getData.getTable("pro_getAllNhom");
            fillComboBox(tbnhom, cbbManhom, "Manhom", "Tennhom");
        }

        private void cbbMaloai_DropDown(object sender, EventArgs e)
        {
            tbloai = BLL_getData.getTable("pro_getAllLoai");
            fillComboBox(tbloai, cbbMaloai, "Maloai", "Tenloai");
        }

        private void frTimKiem_Load(object sender, EventArgs e)
        {
            showData();
        }

        public void showData()
        {

            dataGridView1.DataSource = BLL_getData.getTable("pro_getAllHangHoa");
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[4].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[5].HeaderText = "Mã nhóm";
            dataGridView1.Columns[6].HeaderText = "Mã loại";
            dataGridView1.Columns[7].HeaderText = "Mã đơn vị";
            dataGridView1.Columns[8].HeaderText = "Mã chất liệu";
            dataGridView1.Columns[9].HeaderText = "Mã nước sản xuất";


            dataGridView1.Columns[10].HeaderText = "Thời gian BH";
            dataGridView1.Columns[11].HeaderText = "Ghi chú";
            dataGridView1.Columns[12].HeaderText = "Ảnh";
            // dataGridView1.Columns[5].Visible = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void fillComboBox(DataTable table, ComboBox cmb, string ma, string ten)
        {
            string newc = "NameAndCode";
            AddMultipleColumn(table, newc, ma, ten);
            cmb.DataSource = table;
            cmb.ValueMember = ma;
            cmb.DisplayMember = newc;
            cmb.SelectedIndex = 0;
        }
    }
}
