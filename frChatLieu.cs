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
using DAL;
using Handling;
using Object;

namespace QLBanHangDienTu
{
    public partial class frChatLieu : Form
    {
        int id = -1;
        public frChatLieu()
        {
            InitializeComponent();
        }

        private void frChatLieu_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            dataGridView1.DataSource = getDataDAL.getTable("pro_getAllChatlieu");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (id >= 0 && id < dataGridView1.Rows.Count - 1)
            {
                txtMachatlieu.Text = dataGridView1.Rows[id].Cells["Machatlieu"].Value.ToString();
                txtTenchatlieu.Text = dataGridView1.Rows[id].Cells["Tenchatlieu"].Value.ToString();
            }
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Text = Automatically.autoGetKey("select [dbo].[getKeyChatLieu]()");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkAll() == false) 
                return;
            Obj_ChatLieu obj_ChatLieu 
                = new Obj_ChatLieu(txtMachatlieu.Text, txtTenchatlieu.Text);
            BLL_Chatlieu.insert(obj_ChatLieu);
            showData();
        }

        private bool checkAll()
        {
            if (string.IsNullOrWhiteSpace(txtMachatlieu.Text))
            {
                MessageBox.Show("Tạo mã chất liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenchatlieu.Text))
            {
                MessageBox.Show("Tạo tên chất liệu");
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (id >= 0 && id < dataGridView1.Rows.Count - 1)
            {
                if (checkAll() == false)
                    return;
                Obj_ChatLieu obj_ChatLieu
                    = new Obj_ChatLieu(txtMachatlieu.Text, txtTenchatlieu.Text);
                BLL_Chatlieu.update(obj_ChatLieu);
                showData();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id >= 0 && id < dataGridView1.Rows.Count - 1)
            {
                string mcl = dataGridView1.Rows[id].Cells["Machatlieu"].Value.ToString();
                try { BLL_Chatlieu.delete(mcl); }
                catch { MessageBox.Show("Không thể xóa!"); }
                showData();
            }
        }
    }
}
