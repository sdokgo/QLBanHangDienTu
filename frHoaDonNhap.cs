using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handling;
using BLL;
using Object;
using System.Timers;

namespace QLBanHangDienTu
{
    public partial class frHoaDonNhap : Form
    {
        DataTable tbnv, tbhh, tbncc, tbTemp;
        List<Obj_CTHoaDonNhap> listCTHDBTemp = new List<Obj_CTHoaDonNhap>();
        
        int idOfRowForDel = -1;

        public frHoaDonNhap()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count > 0)
            {
                DialogResult res = MessageBox.Show("Chưa lưu, Có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    listCTHDBTemp.Clear();
                    reset();
                }
                else
                    return;
            }
            tbTemp = new DataTable();

            tbTemp.Columns.Add("Mã hàng");
            tbTemp.Columns.Add("Tên hàng");
            tbTemp.Columns.Add("Số lượng");
            tbTemp.Columns.Add("Đơn giá");
            tbTemp.Columns.Add("Giảm giá");
            tbTemp.Columns.Add("Thành tiền");

            tbHDN.DataSource = tbTemp;
            txtSohdn.Text = Automatically.CreateKey("HDN");

            txtTongtien.Text = "0";
            btnControl(true);
            txtSoluong.Enabled = false;
            txtGiamgia.Enabled = false;
        }

        private void btnControl(bool status)
        {
            btnLammoi.Enabled = status;
            btnLuu.Enabled = status;
            btnXoa.Enabled = status;
            //btnTimkiem.Enabled = status;
            cbbMahang.Enabled = status;
            cbbMaNCC.Enabled = status;
            cbbManv.Enabled = status;
            txtSoluong.Enabled = status;
            txtGiamgia.Enabled = status;
        }

        private void boxControl(string content)
        {
            cbbMahang.Text = content;
            cbbMaNCC.Text = content;
            cbbManv.Text = content;
            txtSohdn.Text = content;
        }


        private void FrHoaDonNhap_Load(object sender, EventArgs e)
        {
          
            showHDN();
            boxControl("");
            btnControl(false);
        }

        private void showHDN()
        {
            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            tbHDN.Columns[0].HeaderText = "Số HĐN";
            tbHDN.Columns[1].HeaderText = "Mã nhân viên";
            tbHDN.Columns[2].HeaderText = "Ngày nhập";
            tbHDN.Columns[3].HeaderText = "Mã nhà cung cấp";
            tbHDN.Columns[4].HeaderText = "Tổng tiền";
        }
        private void fillAllCbb()
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");

            /*fill nha cung cap*/

            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbMaNCC, "MaNCC", "TenNCC");
        }

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
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

        private void CbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getNhacungcapById", cbbMaNCC.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenNCC.Text = tmp.Rows[0]["TenNCC"].ToString();
                txtDiachi.Text = tmp.Rows[0]["Diachi"].ToString();
                txtDienthoai.Text = tmp.Rows[0]["Dienthoai"].ToString();
            }

        }

        private void TbHDN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0 && index <= tbHDN.Rows.Count)
            {
                try
                {
                    string id = tbHDN.Rows[index].Cells["SoHDN"].Value.ToString();
                    //MessageBox.Show(id);
                    tbHDN.DataSource = BLL_getData.getTableById("pro_getCTHDN_ById", id);
                    tbHDN.Columns[0].HeaderText = "Mã hàng";
                    tbHDN.Columns[1].HeaderText = "Tên hàng";
                    tbHDN.Columns[2].HeaderText = "Số lượng";
                    tbHDN.Columns[3].HeaderText = "Đơn giá";
                    tbHDN.Columns[4].HeaderText = "Giảm giá";
                    tbHDN.Columns[5].HeaderText = "Thành tiền";
                }
                catch (Exception)
                {

                }
            }
        }
        private void fillCTHDN(int id)
        {
            if (listCTHDBTemp.Count <= 0)
                return;
            cbbMahang.Text = tbHDN.Rows[id].Cells["Mã hàng"].Value.ToString();
            txtSoluong.Text = tbHDN.Rows[id].Cells["Số lượng"].Value.ToString();
            txtGiamgia.Text = tbHDN.Rows[id].Cells["Giảm giá"].Value.ToString();
            txtTenhang.Text = tbHDN.Rows[id].Cells["Tên hàng"].Value.ToString();
            txtDongia.Text = tbHDN.Rows[id].Cells["Đơn giá"].Value.ToString();
        }

        private void TbHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idOfRowForDel = e.RowIndex;
            fillCTHDN(idOfRowForDel);

            if (e.RowIndex == tbHDN.Rows.Count - 1)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show("Bạn chưa lưu hóa đơn, vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                        return;
                    else { listCTHDBTemp.Clear(); reset(); return; }
                }
                tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            }

        }

        private void LblQuaylai_Click(object sender, EventArgs e)
        {
            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
        }

        private void TxtSoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int giamgia = 0;

                if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == false)
                    giamgia = int.Parse(txtGiamgia.Text);
                if (string.IsNullOrWhiteSpace(txtSoluong.Text) == false)
                {
                    int soluong = int.Parse(txtSoluong.Text);
                    long dongia = long.Parse(txtDongia.Text);
                    long thanhtien = dongia * soluong - (dongia * soluong) * giamgia / 100;
                    txtThanhtien.Text = ((Decimal)thanhtien).ToString();
                }
                else txtThanhtien.Text = "0";
            }
            catch { }

        }

        private void TxtGiamgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                txtGiamgia.Text = int.TryParse(txtGiamgia.Text, out i) == false || i < 0 || i > 100 ? "" : i.ToString();

                if (string.IsNullOrWhiteSpace(txtSoluong.Text) == false)
                {
                    if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == false)
                    {
                        int giamgia = int.Parse(txtGiamgia.Text);
                        int soluong = int.Parse(txtSoluong.Text);
                        long dongia = long.Parse(txtDongia.Text);
                        long thanhtien = dongia * soluong - (dongia * soluong) * giamgia / 100;
                        txtThanhtien.Text = ((Decimal)thanhtien).ToString();
                    }

                }
            }
            catch { }

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count <= 0)
            {
                MessageBox.Show("Chưa có hàng hóa nào?", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Obj_HoaDonNhap obj_HoaDonNhap = new Obj_HoaDonNhap(
                txtSohdn.Text,
                cbbManv.SelectedValue.ToString(),
                dtpNgaytao.Value,
                cbbMaNCC.SelectedValue.ToString(),
                float.Parse(txtTongtien.Text)
                );

            BLL_HoaDonNhap.insertIntoHoadonnhap(obj_HoaDonNhap);


            /*     if (BLL_CTHoaDonNhap.isDuplicateMahanghoa(txtSohdn.Text, cbbMahang.SelectedValue.ToString()))
                 {
                     MessageBox.Show($"Mã hàng {cbbMahang.SelectedValue.ToString()} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }*/

            listCTHDBTemp.ForEach(x => BLL_CTHoaDonNhap.insertIntoCTHoadonnhap(x));

            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            MessageBox.Show($"Thêm thành công hóa đơn:{txtSohdn.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listCTHDBTemp.Clear();
            reset();
        }


        private void BtnLammoi_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count > 0)
            {
                DialogResult res = MessageBox.Show("Chưa lưu, có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    return;
                else { listCTHDBTemp.Clear(); tbTemp.Rows.Clear(); }
            }
            reset();
        }

        private void reset()
        {
            cbbMahang.Text = "";
            cbbMaNCC.Text = "";
            cbbManv.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSohdn.Text = "";
            txtSoluong.Text = "";
            txtNameEmp.Text = "";
            txtTenhang.Text = "";
            txtTenNCC.Text = "";
            txtTongtien.Text = "0";
            btnLuu.Enabled = false;
            txtSoluong.Enabled = false;
            txtGiamgia.Enabled = false;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {

            if (listCTHDBTemp.Count > 0)
            {
                DialogResult res = MessageBox.Show("Chưa lưu, có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    return;
                else { listCTHDBTemp.Clear(); tbTemp.Rows.Clear(); }
            }

            this.Close();
        }

        private void TxtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSoluong.Text.Length > 8 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtGiamgia.Text.Length > 1 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CbbManv_DropDown(object sender, EventArgs e)
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
        }

        private void CbbMahang_DropDown(object sender, EventArgs e)
        {
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");
        }

        private bool checkInputData()
        {
            if (string.IsNullOrWhiteSpace(txtSohdn.Text))
            {
                MessageBox.Show("Chưa tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cbbMaNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaNCC.Focus();
                return false;
            }

            if (cbbManv.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbManv.Focus();
                return false;
            }

            if (cbbMahang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMahang.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoluong.Text) == true)
            {
                MessageBox.Show("Nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == true)
            {
                MessageBox.Show("Nhập giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return false;
            }

            return true;
        }

        private void updateTongtien()
        {
            float tongtien = listCTHDBTemp.Sum(x => x.ThanhTien1);
            txtTongtien.Text = ((Decimal)tongtien).ToString();
        }
        private void BtnThemvaogio_Click(object sender, EventArgs e)
        {

            if (!checkInputData())
                return;

            bool alreadyExists = listCTHDBTemp.Any(x => x.MaHang1 == cbbMahang.SelectedValue.ToString());
            if (alreadyExists)
            {
                MessageBox.Show($"Hàng {cbbMahang.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Obj_CTHoaDonNhap obj_CTHoaDonNhap = new Obj_CTHoaDonNhap(
               txtSohdn.Text,
               cbbMahang.SelectedValue.ToString(),
               int.Parse(txtSoluong.Text),
               float.Parse(txtDongia.Text),
               int.Parse(txtGiamgia.Text),
               float.Parse(txtThanhtien.Text),
               txtTenhang.Text
               );

            listCTHDBTemp.Add(obj_CTHoaDonNhap);


            updateTableTemp();
            updateTongtien();
        }

        private void updateTableTemp()
        {
            tbTemp.Clear();
            foreach (var data in listCTHDBTemp)
            {
                DataRow row = tbTemp.NewRow();
                row["Mã hàng"] = data.MaHang1;
                row["Tên hàng"] = data.TenHang1;
                row["Số lượng"] = data.SoLuong1;
                row["Đơn giá"] = data.DonGia1;
                row["Giảm giá"] = data.GiamGia1;
                row["Thành tiền"] = (Decimal)data.ThanhTien1;
                tbTemp.Rows.Add(row);
            }
            tbHDN.DataSource = tbTemp;
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (idOfRowForDel >= 0 && idOfRowForDel < tbHDN.Rows.Count)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show($"Bạn muốn xóa hàng {tbHDN.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString()}", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        listCTHDBTemp.RemoveAt(idOfRowForDel);
                        tbTemp.Rows.RemoveAt(idOfRowForDel);
                        updateTongtien();
                    }
                }
                else { MessageBox.Show("Chỉ có thể xóa trong giỏ hàng!"); }
            }
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            if(idOfRowForDel >= 0 && idOfRowForDel < tbTemp.Rows.Count)
            {
                string mh = tbHDN.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString();
                var obj = listCTHDBTemp.FirstOrDefault(x => x.MaHang1 == mh);

                if (listCTHDBTemp.Count > 0)
                {
                    obj.SoLuong1 = int.Parse(txtSoluong.Text);
                    obj.GiamGia1 = int.Parse(txtGiamgia.Text);
                }

                updateTableTemp();
                MessageBox.Show($"Sửa thành công mã hàng {mh}!");
            }

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frTimKiemHDN frhdn = new frTimKiemHDN();
            frhdn.Show();
        }

        private void CbbMaNCC_DropDown(object sender, EventArgs e)
        {
            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbMaNCC, "MaNCC", "TenNCC");
        }

        private void CbbTenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiamgia.Enabled = true;
            txtSoluong.Enabled = true;
            DataTable tmp = BLL_getData.getTableById("pro_getHanghoaById", cbbMahang.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenhang.Text = tmp.Rows[0]["Tenhang"].ToString();
                txtDongia.Text = tmp.Rows[0]["Dongianhap"].ToString();
            }
        }

        private void CbbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getNhanvienById", cbbManv.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
                txtNameEmp.Text = tmp.Rows[0]["Tennhanvien"].ToString();
        }


    }
}
