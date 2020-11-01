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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtTK.Text == null || txtTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản","Cảnh báo");
            } else if(txtTK.Text == null || txtTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu","Cảnh báo");
            } else
            {
                String tk = txtTK.Text;
                String mk = txtMK.Text;
                SqlConnection sql = getConnectionSql.connectToSql();
                sql.Open();
                String s = "Select * from TaiKhoan where TenTaiKhoan=@TK and MatKhau=@MK";
                SqlCommand command = new SqlCommand(s, sql);
                command.Parameters.AddWithValue("@TK", tk);
                command.Parameters.AddWithValue("@MK", mk);

                SqlDataReader reader = command.ExecuteReader();
                TaiKhoan taiKhoan = null;
                while (reader.Read())
                {
                        taiKhoan = new TaiKhoan(reader.GetString(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetString(3));
                }
                if(taiKhoan != null)
                {
                    Form1 form1 = new Form1(taiKhoan);
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Cảnh báo");
                }

                sql.Close();
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)13 là keypress Enter
            if(e.KeyChar == (char)13)
            {
                btnDN_Click(null, null);
            }
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)13 là keypress Enter
            if (e.KeyChar == (char)13)
            {
                txtMK.Focus();
            }
        }
    }
}
