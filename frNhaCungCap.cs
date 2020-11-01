using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Handling;
using Object;

namespace QLBanHangDienTu
{
    public partial class frNhaCungCap : Form
    {
        int index = -1;
        public frNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = Automatically.autoGetKey("select dbo.getKeyNhaCC()").Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Obj_NhaCungCap obj_NhaCungCap = new Obj_NhaCungCap(
                txtMaNCC.Text,
                txtTenncc.Text,
                rtbDiachi.Text,
                txtDienthoai.Text
                );
            BLL_NhaCungCap.insert(obj_NhaCungCap);
            showTableNCC();
        }

        private void frNhaCungCap_Load(object sender, EventArgs e)
        {
            showTableNCC();
        }

        private void showTableNCC()
        {
            dgvNhaCC.DataSource = BLL_getData.getTable("pro_getAllNhacungcap");
            dgvNhaCC.Columns[0].HeaderText = "Mã NCC";
            dgvNhaCC.Columns[1].HeaderText = "Tên NCC";
            dgvNhaCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Điện thoại";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvNhaCC.Rows.Count)
            {
                string id = dgvNhaCC.Rows[index].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Muốn xóa hàng {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {
                    BLL_NhaCungCap.delete(id);
                    dgvNhaCC.Rows.RemoveAt(index);
                } 
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Obj_NhaCungCap obj_NhaCungCap
                = new Obj_NhaCungCap(txtMaNCC.Text, txtTenncc.Text, rtbDiachi.Text, txtDienthoai.Text);
            BLL_NhaCungCap.update(obj_NhaCungCap);
            showTableNCC();
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaNCC.Text = dgvNhaCC.Rows[index].Cells[0].Value.ToString();
            txtTenncc.Text = dgvNhaCC.Rows[index].Cells[1].Value.ToString();
            rtbDiachi.Text = dgvNhaCC.Rows[index].Cells[2].Value.ToString();
            txtDienthoai.Text = dgvNhaCC.Rows[index].Cells[3].Value.ToString();
        }

  

        private void btnLammoi_Click_1(object sender, EventArgs e)
        {
            txtTenncc.Text = "";
            txtMaNCC.Text = "";
            txtDienthoai.Text = "";
            rtbDiachi.Text = "";
        }
    }
}
