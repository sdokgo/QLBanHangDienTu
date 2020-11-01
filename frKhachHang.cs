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
    public partial class frKhachHang : Form
    {
        int index = -1;
        public frKhachHang()
        {
            InitializeComponent();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMakh.Text = Automatically.autoGetKey("select dbo.getKeyKhachhang()").Trim();
        }

        private void showTableKhachhang()
        {
            dgvKhachang.DataSource = BLL_getData.getTable("pro_getAllKhachhang");
            dgvKhachang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachang.Columns[3].HeaderText = "Điện thoại";
        }

        private void frKhachHang_Load(object sender, EventArgs e)
        {
            showTableKhachhang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvKhachang.Rows.Count)
            {
                string id = dgvKhachang.Rows[index].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Muốn xóa khách hàng {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    BLL_KhachHang.delete(id);
                    dgvKhachang.Rows.RemoveAt(index);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Obj_KhachHang obj_KhachHang
               = new Obj_KhachHang(txtMakh.Text, txtTenkh.Text, rtbDiachi.Text, txtDienthoai.Text);
            BLL_KhachHang.update(obj_KhachHang);
            showTableKhachhang();
        }

        private void dgvKhachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMakh.Text = dgvKhachang.Rows[index].Cells[0].Value.ToString();
            txtTenkh.Text = dgvKhachang.Rows[index].Cells[1].Value.ToString();
            rtbDiachi.Text = dgvKhachang.Rows[index].Cells[2].Value.ToString();
            txtDienthoai.Text = dgvKhachang.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Obj_KhachHang obj_KhachHang = new Obj_KhachHang(
                txtMakh.Text,
                txtTenkh.Text,
                rtbDiachi.Text,
                txtDienthoai.Text
                );
            BLL_KhachHang.insert(obj_KhachHang);
            showTableKhachhang();
        }


        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtTenkh.Text = "";
            txtMakh.Text = "";
            txtDienthoai.Text = "";
            rtbDiachi.Text = "";
        }
    }
}
