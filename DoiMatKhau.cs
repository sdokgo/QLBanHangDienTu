using Object;
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

namespace QLBanHangDienTu
{
    public partial class DoiMatKhau : Form
    {
        private TaiKhoan taiKhoan;
        public DoiMatKhau(TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoan = tk;
        }

        public TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if(txtMKC.Text == null || txtMKC.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ","Cảnh báo");
            } else if(txtMKM.Text == null || txtMKM.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Cảnh báo");
            } else if (txtMKM2.Text == null || txtMKM2.Text == "")
            {
                MessageBox.Show("Bạn phải lại nhập mật khẩu mới", "Cảnh báo");
            } else if (txtMKM.Text != txtMKM2.Text)
            {
                MessageBox.Show("Nhập lại mật mới không khớp", "Cảnh báo");
            } else if (txtMKC.Text != taiKhoan.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác","Cảnh báo");
            } else
            {
                SqlConnection sql = getConnectionSql.connectToSql();
                sql.Open();
                String s = "Update TaiKhoan SET MatKhau=@MK where TenTaiKhoan=@TK";
                SqlCommand command = new SqlCommand(s, sql);
                command.Parameters.AddWithValue("@TK", taiKhoan.TenTaiKhoan);
                command.Parameters.AddWithValue("@MK", txtMKM.Text);
                int row = 0;
                row = command.ExecuteNonQuery();
                sql.Close();
                if(row != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Đổi mật khẩu thành công",
                        "Thông Báo",MessageBoxButtons.OK);
                    taiKhoan.MatKhau = txtMKM.Text;
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void txtMKC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)13 là keypress Enter
            if (e.KeyChar == (char)13)
            {
                txtMKM.Focus();
            }
        }

        private void txtMKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)13 là keypress Enter
            if (e.KeyChar == (char)13)
            {
                txtMKM2.Focus();
            }
        }

        private void txtMKM2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)13 là keypress Enter
            if (e.KeyChar == (char)13)
            {
                btnChangePass_Click(null, null);
            }
        }
    }
}
