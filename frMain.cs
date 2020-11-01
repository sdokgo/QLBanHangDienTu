using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Handling;
using Object;

namespace QLBanHangDienTu
{
    public partial class Form1 : Form
    {
        public Form1(TaiKhoan tk)
        {
            InitializeComponent();
            myAccount = tk;
            if(myAccount.PhanQuyen != 1)
            {
                báoCaoToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
            }
        }

        private TaiKhoan myAccount;

        public TaiKhoan MyAccount { get => myAccount; set => myAccount = value; }

        private void HàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frDMHanghoa frHH = new frDMHanghoa();
            frHH.MdiParent = this;
            frHH.Dock = DockStyle.Fill;
            frHH.Show();
        }

        private void closeDuplicateForm()
        {
            if (this.MdiChildren.FirstOrDefault() != null)
                this.MdiChildren.FirstOrDefault().Close();
        }

        private void HóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frHoaDonNhap frhdn = new frHoaDonNhap();
            frhdn.MdiParent = this;
            frhdn.Dock = DockStyle.Fill;
            frhdn.Show();
        }
        private void ĐăngXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void NhàcungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frNhaCungCap frNcc = new frNhaCungCap();
            frNcc.MdiParent = this;
            frNcc.Dock = DockStyle.Fill;
            frNcc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frNhanVien frnv = new frNhanVien();
            frnv.MdiParent = this;
            frnv.Dock = DockStyle.Fill;
            frnv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frKhachHang frkh = new frKhachHang();
            frkh.MdiParent = this;
            frkh.Dock = DockStyle.Fill;
            frkh.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frHoaDonBan frhdb = new frHoaDonBan();
            frhdb.MdiParent = this;
            frhdb.Dock = DockStyle.Fill;
            frhdb.Show();
        }


        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frTimKiemHDN frhdn = new frTimKiemHDN();
            frhdn.MdiParent = this;
            frhdn.Dock = DockStyle.Fill;
            frhdn.Show();
        }

      
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport1 frBCHanghoa = new frReport1();
            frBCHanghoa.MdiParent = this;
            frBCHanghoa.Dock = DockStyle.Fill;
            frBCHanghoa.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport2 frBCHoadon = new frReport2();
            frBCHoadon.MdiParent = this;
            frBCHoadon.Dock = DockStyle.Fill;
            frBCHoadon.Show();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport3 frBCDoanhthu = new frReport3();
            frBCDoanhthu.MdiParent = this;
            frBCDoanhthu.Dock = DockStyle.Fill;
            frBCDoanhthu.Show();
        }

        private void báoCáoNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport4 frBCNCC = new frReport4();
            frBCNCC.MdiParent = this;
            frBCNCC.Dock = DockStyle.Fill;
            frBCNCC.Show();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.FirstOrDefault() != null)
                this.MdiChildren.FirstOrDefault().Close();
            frTimKiemHang frtk = new frTimKiemHang();
            frtk.MdiParent = this;
            frtk.Dock = DockStyle.Fill;
            frtk.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frChatLieu frcl = new frChatLieu();
            frcl.MdiParent = this;
            frcl.Dock = DockStyle.Fill;
            frcl.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(MyAccount);
            doiMatKhau.Show();
            myAccount = doiMatKhau.TaiKhoan;
        }
    }
}
