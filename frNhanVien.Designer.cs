namespace QLBanHangDienTu
{
    partial class frNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMaca = new System.Windows.Forms.ComboBox();
            this.cbbMacv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(193, 33);
            this.txtManv.Name = "txtManv";
            this.txtManv.ReadOnly = true;
            this.txtManv.Size = new System.Drawing.Size(141, 22);
            this.txtManv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV";
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(193, 76);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(226, 22);
            this.txtTennv.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(636, 28);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(226, 22);
            this.txtDienthoai.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã ca";
            // 
            // cbbMaca
            // 
            this.cbbMaca.FormattingEnabled = true;
            this.cbbMaca.Location = new System.Drawing.Point(193, 170);
            this.cbbMaca.Name = "cbbMaca";
            this.cbbMaca.Size = new System.Drawing.Size(141, 24);
            this.cbbMaca.TabIndex = 4;
            this.cbbMaca.DropDown += new System.EventHandler(this.cbbMaca_DropDown);
            // 
            // cbbMacv
            // 
            this.cbbMacv.FormattingEnabled = true;
            this.cbbMacv.Location = new System.Drawing.Point(193, 213);
            this.cbbMacv.Name = "cbbMacv";
            this.cbbMacv.Size = new System.Drawing.Size(141, 24);
            this.cbbMacv.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã CV";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(649, 208);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(766, 210);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 7;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(36, 289);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(932, 267);
            this.dgvNhanvien.TabIndex = 9;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(193, 121);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(159, 22);
            this.dtpNgaysinh.TabIndex = 11;
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(48, 615);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(75, 26);
            this.btnTaomoi.TabIndex = 12;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(193, 615);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 615);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(510, 615);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(672, 615);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 26);
            this.btnLammoi.TabIndex = 12;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(848, 615);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 26);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(636, 93);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(224, 69);
            this.txtDiachi.TabIndex = 13;
            // 
            // frNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.cbbMacv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtManv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frNhanVien";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaca;
        private System.Windows.Forms.ComboBox cbbMacv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDiachi;
    }
}