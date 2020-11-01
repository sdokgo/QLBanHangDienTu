namespace QLBanHangDienTu
{
    partial class frTimKiemHDN
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
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.tbHDN = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMahang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNhacungcap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grTime = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).BeginInit();
            this.grTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(480, 272);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(102, 28);
            this.btnLammoi.TabIndex = 31;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(274, 272);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(84, 28);
            this.btnTimkiem.TabIndex = 30;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // tbHDN
            // 
            this.tbHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbHDN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHDN.Location = new System.Drawing.Point(12, 333);
            this.tbHDN.Name = "tbHDN";
            this.tbHDN.ReadOnly = true;
            this.tbHDN.RowHeadersWidth = 51;
            this.tbHDN.RowTemplate.Height = 24;
            this.tbHDN.Size = new System.Drawing.Size(976, 310);
            this.tbHDN.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Từ";
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "dd-MM-yyyy";
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(98, 21);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(117, 22);
            this.dtpTu.TabIndex = 32;
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "dd-MM-yyyy";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(320, 21);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(124, 22);
            this.dtpDen.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Đến";
            // 
            // cbbMahang
            // 
            this.cbbMahang.FormattingEnabled = true;
            this.cbbMahang.Location = new System.Drawing.Point(355, 47);
            this.cbbMahang.Name = "cbbMahang";
            this.cbbMahang.Size = new System.Drawing.Size(187, 24);
            this.cbbMahang.TabIndex = 23;
            this.cbbMahang.DropDown += new System.EventHandler(this.CbbMahang_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã hàng";
            // 
            // cbbNhacungcap
            // 
            this.cbbNhacungcap.FormattingEnabled = true;
            this.cbbNhacungcap.Location = new System.Drawing.Point(355, 104);
            this.cbbNhacungcap.Name = "cbbNhacungcap";
            this.cbbNhacungcap.Size = new System.Drawing.Size(187, 24);
            this.cbbNhacungcap.TabIndex = 25;
            this.cbbNhacungcap.DropDown += new System.EventHandler(this.CbbMaNCC_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nhà cung cấp";
            // 
            // grTime
            // 
            this.grTime.Controls.Add(this.dtpDen);
            this.grTime.Controls.Add(this.label11);
            this.grTime.Controls.Add(this.dtpTu);
            this.grTime.Controls.Add(this.label1);
            this.grTime.Location = new System.Drawing.Point(237, 181);
            this.grTime.Name = "grTime";
            this.grTime.Size = new System.Drawing.Size(486, 63);
            this.grTime.TabIndex = 35;
            this.grTime.TabStop = false;
            this.grTime.Text = "Tìm kiếm theo thời gian";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(237, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 21);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Tìm kiếm theo thời gian";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frTimKiemHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbNhacungcap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMahang);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.tbHDN);
            this.Name = "frTimKiemHDN";
            this.Text = "frTimKiemHDN";
            this.Load += new System.EventHandler(this.frTimKiemHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).EndInit();
            this.grTime.ResumeLayout(false);
            this.grTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView tbHDN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMahang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNhacungcap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grTime;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}