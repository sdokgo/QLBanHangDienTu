using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLBanHangDienTu
{
    public partial class frTimKiemHDN : Form
    {
        public frTimKiemHDN()
        {
            InitializeComponent();
        }

        DataTable tbhh, tbncc;

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void CbbMahang_DropDown(object sender, EventArgs e)
        {
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");
        }

        private void CbbMaNCC_DropDown(object sender, EventArgs e)
        {
            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbNhacungcap, "MaNCC", "TenNCC");
        }

        private void frTimKiemHDN_Load(object sender, EventArgs e)
        {
            grTime.Visible = false;
            showHDN();
        }
        private void showHDN()
        {
            tbHDN.DataSource = BLL_getData.getTable("pro_getDataForQuestion5");
            tbHDN.Columns[0].HeaderText = "Số HĐN";
            tbHDN.Columns[1].HeaderText = "Mã hàng";
            tbHDN.Columns[2].HeaderText = "Mã MCC";
            tbHDN.Columns[3].HeaderText = "Mã NV";
            tbHDN.Columns[4].HeaderText = "Ngày nhập";
            tbHDN.Columns[5].HeaderText = "Số lượng";
            tbHDN.Columns[6].HeaderText = "Đơn giá";
            tbHDN.Columns[7].HeaderText = "Giảm giá";
            tbHDN.Columns[8].HeaderText = "Thành tiền";   
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            showHDN();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL_getData.getTable("pro_getDataForQuestion5");
            IEnumerable<DataRow> result = dt.AsEnumerable().Where(
                r =>
                (
                    (cbbMahang.SelectedIndex == -1 ? true :
                    r.Field<string>("Mahang").Contains(cbbMahang.SelectedValue.ToString()))
                    &&
                    (cbbNhacungcap.SelectedIndex == -1 ? true :
                    r.Field<string>("MaNCC").Contains(cbbNhacungcap.SelectedValue.ToString()))
                 )
             );

            try
            {
                DataTable t = result.CopyToDataTable();



                IEnumerable<DataRow> filterByDatetime = t.AsEnumerable().Where(
                    r => (
                        DateTime.Compare(r.Field<DateTime>("Ngaynhap"), Convert.ToDateTime(dtpTu.Value.ToString("MM/dd/yyyy"))) >= 0
                          && DateTime.Compare(r.Field<DateTime>("Ngaynhap"), Convert.ToDateTime(dtpDen.Value.ToString("MM/dd/yyyy"))) <= 0
                    )
                );

                if (checkBox1.Checked)
                    t = filterByDatetime.CopyToDataTable();
                

                tbHDN.DataSource = t;
                tbHDN.Refresh();
            }
            catch (Exception) { }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                grTime.Visible = true;
            else
                grTime.Visible = false;
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
