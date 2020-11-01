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
    public partial class frHoaDonBan : Form
    {
        DataTable tbhh, tbnv, tbkh, tbTemp;

        int idOfRowForDel = -1;

        int cur_amount;

        List<Obj_CTHoaDonBan> listCTHDBTemp = new List<Obj_CTHoaDonBan>();

        public frHoaDonBan()
        {
            InitializeComponent();
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

        private void cbbManv_DropDown(object sender, EventArgs e)
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
        }

        private void cbbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getNhanvienById", cbbManv.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
                txtNameEmp.Text = tmp.Rows[0]["Tennhanvien"].ToString();
        }

        private void cbbMahang_DropDown(object sender, EventArgs e)
        {
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");
        }

        private void cbbMakhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getKhachhangById", cbbMakhach.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenhkhach.Text = tmp.Rows[0]["Tenkhach"].ToString();
                txtDiachi.Text = tmp.Rows[0]["Diachi"].ToString();
                txtDienthoai.Text = tmp.Rows[0]["Dienthoai"].ToString();
            }
        }

        private void reset()
        {
            cbbMahang.Text = "";
            cbbMakhach.Text = "";
            cbbManv.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSohdb.Text = "";
            txtSoluong.Text = "";
            txtNameEmp.Text = "";
            txtTenhang.Text = "";
            txtTenhkhach.Text = "";
            txtTongtien.Text = "0";
            btnLuu.Enabled = false;
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
            cbbMakhach.Enabled = status;
            cbbManv.Enabled = status;
            txtSoluong.Enabled = status;
            txtGiamgia.Enabled = status;
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
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

                tbHDB.DataSource = tbTemp;
                txtSohdb.Text = Automatically.CreateKey("HDB");

                txtTongtien.Text = "0";
                btnControl(true);
                txtSoluong.Enabled = false;
                txtGiamgia.Enabled = false;
  
        }

        private void showHDB()
        {
            tbHDB.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
            tbHDB.Columns[0].HeaderText = "Số HĐB";
            tbHDB.Columns[1].HeaderText = "Mã nhân viên";
            tbHDB.Columns[2].HeaderText = "Ngày bán";
            tbHDB.Columns[3].HeaderText = "Mã khách";
            tbHDB.Columns[4].HeaderText = "Tổng tiền";
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
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

        private void frHoaDonBan_Load(object sender, EventArgs e)
        {
            showHDB();
            boxControl("");
            btnControl(false);
        }

        private void boxControl(string content)
        {
            cbbMahang.Text = content;
            cbbMakhach.Text = content;
            cbbManv.Text = content;
            txtSohdb.Text = content;
        }

        private void tbHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idOfRowForDel = e.RowIndex;

            if (idOfRowForDel >= 0 && idOfRowForDel < listCTHDBTemp.Count)
            {
                DataTable temp = BLL_getData.getTableById("pro_getHanghoaById", tbHDB.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString());
                cur_amount = temp.Rows[0].Field<int>("Soluong");
                //cur_amount += int.Parse(txtSoluong.Text);
            }
  
            if (e.RowIndex == tbHDB.Rows.Count - 1)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show("Bạn chưa lưu hóa đơn, vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                        return;
                    else { listCTHDBTemp.Clear(); reset(); return; }
                }
                tbHDB.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
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

        private void txtSoluong_TextChanged(object sender, EventArgs e)
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

        private void btnLammoi_Click(object sender, EventArgs e)
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

        private void updateTongtien()
        {
            float tongtien = listCTHDBTemp.Sum(x => x.ThanhTien1);
            txtTongtien.Text = ((Decimal)tongtien).ToString();
        }

        private void btnThemvaogio_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
                return;

            bool alreadyExists = listCTHDBTemp.Any(x => x.MaHang1 == cbbMahang.SelectedValue.ToString());
            if (alreadyExists)
            {
                MessageBox.Show($"Hàng {cbbMahang.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            DataTable temp = BLL_getData.getTableById("pro_getHanghoaById", cbbMahang.SelectedValue.ToString());
            if(temp.Rows.Count > 0) 
                   cur_amount = temp.Rows[0].Field<int>("Soluong");

            if (cur_amount - int.Parse(txtSoluong.Text) < 0)
            {
                MessageBox.Show($"{cbbMahang.ValueMember.ToString()} còn {cur_amount} cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            Obj_CTHoaDonBan obj_CTHoaDonBan = new Obj_CTHoaDonBan(
               txtSohdb.Text,
               cbbMahang.SelectedValue.ToString(),
               int.Parse(txtSoluong.Text),
               float.Parse(txtDongia.Text),
               int.Parse(txtGiamgia.Text),
               float.Parse(txtThanhtien.Text),
               txtTenhang.Text
               );

            listCTHDBTemp.Add(obj_CTHoaDonBan);

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



           

            tbHDB.DataSource = tbTemp;

            updateTongtien();
        }

        private bool checkInputData()
        {
            if (string.IsNullOrWhiteSpace(txtSohdb.Text))
            {
                MessageBox.Show("Chưa tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cbbMakhach.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMakhach.Focus();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idOfRowForDel >= 0 && idOfRowForDel < tbHDB.Rows.Count)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show($"Bạn muốn xóa hàng {tbHDB.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString()}", "Thông báo", MessageBoxButtons.YesNo);
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
            tbHDB.DataSource = tbTemp;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idOfRowForDel >= 0 && idOfRowForDel < tbTemp.Rows.Count)
            {
                
                string mh = tbHDB.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString();

                
                if (cur_amount - int.Parse(txtSoluong.Text) < 0)
                {
                    MessageBox.Show($"{mh} còn {cur_amount} cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var obj = listCTHDBTemp.FirstOrDefault(x => x.MaHang1 == mh);

                obj.SoLuong1 = int.Parse(txtSoluong.Text);
                obj.GiamGia1 = int.Parse(txtGiamgia.Text);

                updateTableTemp();
                MessageBox.Show($"Sửa thành công mã hàng {mh}!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count <= 0)
            {
                MessageBox.Show("Chưa có hàng hóa nào?", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Obj_HoaDonBan obj_HoaDonBan = new Obj_HoaDonBan(
                txtSohdb.Text,
                cbbManv.SelectedValue.ToString(),
                dtpNgaytao.Value,
                cbbMakhach.SelectedValue.ToString(),
                float.Parse(txtTongtien.Text)
                );

            BLL_HoaDonBan.insert(obj_HoaDonBan);
            listCTHDBTemp.ForEach(x => BLL_CTHoaDonBan.insert(x));

            tbHDB.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
            MessageBox.Show($"Thêm thành công hóa đơn:{txtSohdb.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listCTHDBTemp.Clear();
            reset();
        }

        private void tbHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0 && index <= tbHDB.Rows.Count)
            {
                try
                {
                    string id = tbHDB.Rows[index].Cells["SoHDB"].Value.ToString();
                    //MessageBox.Show(id);
                    tbHDB.DataSource = BLL_getData.getTableById("pro_getCTHDB_ById", id);
                    tbHDB.Columns[0].HeaderText = "Mã hàng";
                    tbHDB.Columns[1].HeaderText = "Tên hàng";
                    tbHDB.Columns[2].HeaderText = "Số lượng";
                    tbHDB.Columns[3].HeaderText = "Đơn giá";
                    tbHDB.Columns[4].HeaderText = "Giảm giá";
                    tbHDB.Columns[5].HeaderText = "Thành tiền";
                }
                catch (Exception)
                {

                }
            }
        }

  

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            tbHDB.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSoluong.Text.Length > 8 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbMakhach_DropDown(object sender, EventArgs e)
        {
            tbkh = BLL_getData.getTable("pro_getAllKhachhang");
            fillComboBox(tbkh, cbbMakhach, "Makhach", "Tenkhach");
        }

        private void cbbMahang_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
