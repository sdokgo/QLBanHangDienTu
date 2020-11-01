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
using Handling;
using Object;

namespace QLBanHangDienTu
{
    public partial class frNhanVien : Form
    {
        int index = -1;
        public frNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frNhanVien_Load(object sender, EventArgs e)
        {
            rdbNu.Checked = true;
            showTableNhanvien();
        }

        private void showTableNhanvien()
        {
            dgvNhanvien.DataSource = BLL_getData.getTable("proc_getDataFromNhanvien");
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns[2].HeaderText = "Giới tính";
            dgvNhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanvien.Columns[5].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[6].HeaderText = "Mã ca";
            dgvNhanvien.Columns[7].HeaderText = "Mã công việc";
        }

       

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtManv.Text = Automatically.autoGetKey("select dbo.getKeyNhanvien()").Trim();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            cbbMaca.SelectedIndex = -1;
            cbbMacv.SelectedIndex = -1;
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            rdbNu.Checked = true;
        }

        private void cbbMaca_DropDown(object sender, EventArgs e)
        {
           /* DataTable tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbMaca, "MaNV", "Tennhanvien");*/
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

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkAll() == false)
                return;
         
            Obj_NhanVien obj_NhanVien = new Obj_NhanVien(
                txtManv.Text,
                txtTennv.Text,
                rdbNam.Checked ? "Nam": "Nữ",
                dtpNgaysinh.Value,
                txtDienthoai.Text,
                txtDiachi.Text,
                cbbMaca.Text,
                cbbMacv.Text
                );

            BLL_NhanVien.insert(obj_NhanVien);
            showTableNhanvien();
        }

        private bool checkAll()
        {
            return true;
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
            txtTennv.Text = dgvNhanvien.Rows[index].Cells[1].Value.ToString();
            rdbNam.Checked = dgvNhanvien.Rows[index].Cells[2].Value.ToString() == "Nam" ? true : false;
            rdbNu.Checked = dgvNhanvien.Rows[index].Cells[2].Value.ToString() == "Nữ" ? true : false;
            dtpNgaysinh.Value = (DateTime)dgvNhanvien.Rows[index].Cells[3].Value;
            txtDienthoai.Text = dgvNhanvien.Rows[index].Cells[4].Value.ToString();
            txtDiachi.Text = dgvNhanvien.Rows[index].Cells[5].Value.ToString();
            cbbMaca.Text = dgvNhanvien.Rows[index].Cells[6].Value.ToString();
            cbbMacv.Text = dgvNhanvien.Rows[index].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvNhanvien.Rows.Count)
            {
                string id = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Muốn xóa nhân viên {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    BLL_NhanVien.delete(id);
                    dgvNhanvien.Rows.RemoveAt(index);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            Obj_NhanVien obj_NhanVien = new Obj_NhanVien(
                txtManv.Text,
                txtTennv.Text,
                rdbNam.Checked ? "Nam" : "Nữ",
                dtpNgaysinh.Value,
                txtDienthoai.Text,
                txtDiachi.Text,
                cbbMaca.Text,
                cbbMacv.Text
                );

            BLL_NhanVien.update(obj_NhanVien);
            showTableNhanvien();
        }
    }
}
