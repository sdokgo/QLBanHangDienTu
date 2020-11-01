using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using Handling;
using BLL;
using System.IO;


namespace QLBanHangDienTu
{
    public partial class frDMHanghoa : Form
    {
        int index;
        byte[] curImg = null;
        public frDMHanghoa()
        {
            InitializeComponent();
        }

        private void FrDMHanghoa_Load(object sender, EventArgs e)
        {
            showData();
            cbbMadonvi_DropDown(null, null);
            cbbMadonvi.SelectedIndex = -1;
            cbbMaloai_DropDown(null, null);
            cbbMaloai.SelectedIndex = -1;
            cbbManhom_DropDown(null, null);
            cbbManhom.SelectedIndex = -1;
            cbbManuocsx_DropDown(null, null);
            cbbManuocsx.SelectedIndex = -1;
            cbbMachatlieu_DropDown(null, null);
            cbbMachatlieu.SelectedIndex = -1;
        }

        private Obj_HangHoa newObj_hanghoa()
        {
            try { curImg = toByte(ptbAnh.Image); }
            catch { }
            Obj_HangHoa hangHoaObj = new Obj_HangHoa(
               txtMahang.Text,
               txtTenhang.Text,
               int.Parse(txtSoluong.Text),
               float.Parse(txtDonggianhap.Text),
               float.Parse(txtDongiaban.Text),
               cbbManhom.SelectedValue.ToString(),
               cbbMaloai.SelectedValue.ToString(),
               cbbMadonvi.SelectedValue.ToString(),
               cbbMachatlieu.SelectedValue.ToString(),
               cbbManuocsx.SelectedValue.ToString(),
               int.Parse(txtThoigianbaohanh.Text),
               txtGhichu.Text,
               curImg
           );
            return hangHoaObj;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!checkAll())
                return;
            BLL_DMHangHoa.insertIntoDMHangHoa(newObj_hanghoa());
            showData();
        }

        private bool checkAll()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox && ((TextBox)ctl).Name == "txtGhichu") 
                    continue;
                if (ctl is TextBox && ((TextBox)ctl).Text.Trim() == "") 
                {
                    MessageBox.Show(((TextBox)ctl).Name.ToString() + " trống!");
                    return false;
                }

                if (ctl is ComboBox && ((ComboBox)ctl).SelectedIndex == -1)
                {
                    MessageBox.Show(((ComboBox)ctl).Name.ToUpperInvariant() + " chưa được chọn!");
                    return false;
                }
            }
            return true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtMahang.Text = Automatically.autoGetKey("select dbo.getKeyHangHoa()").Trim();
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
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (index >= 0 && index < dataGridView1.Rows.Count - 1)
            {
                if (!checkAll())
                    return;
                BLL_DMHangHoa.update(newObj_hanghoa());
                MessageBox.Show("Sửa thành công!");
                showData();
                // dataGridView1.RefreshEdit();
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BLL.BLL_DMHangHoa.deleteFromDMHangHoa(txtMahang.Text);
            showData();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    ((TextBox)ctl).Text = "";
                if (ctl is ComboBox)
                    ((ComboBox)ctl).SelectedIndex = -1;
            }
            ptbAnh.Image = null;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMahang.Text = dataGridView1.Rows[index].Cells["Mahang"].Value.ToString();
                txtTenhang.Text = dataGridView1.Rows[index].Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = dataGridView1.Rows[index].Cells["Soluong"].Value.ToString();
                txtDonggianhap.Text = dataGridView1.Rows[index].Cells["Dongianhap"].Value.ToString();
                txtDongiaban.Text = dataGridView1.Rows[index].Cells["Dongiaban"].Value.ToString();

                /*show combobox*/
              //  DataGridViewRow canRows = dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == txtMahang.Text);
                cbbManhom.SelectedValue = dataGridView1.Rows[index].Cells["Manhom"].Value.ToString();
                cbbMadonvi.SelectedValue = dataGridView1.Rows[index].Cells["Madonvi"].Value.ToString();
                cbbMachatlieu.SelectedValue = dataGridView1.Rows[index].Cells["Machatlieu"].Value.ToString();
                cbbManuocsx.SelectedValue = dataGridView1.Rows[index].Cells["MaNuocSX"].Value.ToString();
                cbbMaloai.SelectedValue = dataGridView1.Rows[index].Cells["Maloai"].Value.ToString();
                /**/

                txtGhichu.Text = dataGridView1.Rows[index].Cells["Ghichu"].Value.ToString();
                txtThoigianbaohanh.Text = dataGridView1.Rows[index].Cells["Thoigianbaohanh"].Value.ToString();

                try
                {
                    curImg = (byte[])dataGridView1.Rows[index].Cells["Anh"].Value;
                    ptbAnh.Image = toImage(curImg);
                }
                catch { ptbAnh.Image = null; }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All File (*.*)|*.*";
            OD.FilterIndex = 3;
            OD.RestoreDirectory = true;
            if (OD.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAnh.Load(OD.FileName);
            }
        }

        private Image toImage(byte[] b)
        {
            using (var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }
        private byte[] toByte(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] arrByte = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return arrByte;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonggianhap.Text) == false)
            {
                float dongianhap = float.Parse(txtDonggianhap.Text);
                float dongiaban = dongianhap + (dongianhap * 1 / 10);
                txtDongiaban.Text = ((Decimal)dongiaban).ToString();
            }

        }

        DataTable tbnhom, tbloai, tbdv, tbcl, tbnsx;



        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void cbbMadonvi_DropDown(object sender, EventArgs e)
        {
            tbdv = BLL_getData.getTable("pro_getAllDonvi");
            fillComboBox(tbdv, cbbMadonvi, "Madonvitinh", "Tendonvitinh");
        }

        private void cbbMachatlieu_DropDown(object sender, EventArgs e)
        {
            tbcl = BLL_getData.getTable("pro_getAllChatlieu");
            fillComboBox(tbcl, cbbMachatlieu, "Machatlieu", "Tenchatlieu");
        }

        private void cbbManuocsx_DropDown(object sender, EventArgs e)
        {
            tbnsx = BLL_getData.getTable("pro_getAllNuocSX");
            fillComboBox(tbnsx, cbbManuocsx, "MaNuocSX", "TenNuocSX");
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            /*  if (this.MdiChildren.FirstOrDefault() != null)
                  this.MdiChildren.FirstOrDefault().Close();*/
            frTimKiemHang frtk = new frTimKiemHang();
            frtk.Show();
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
