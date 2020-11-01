namespace QLBanHangDienTu
{
    partial class frKhachHang
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
            this.rtbDiachi = new System.Windows.Forms.RichTextBox();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachang = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachang)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDiachi
            // 
            this.rtbDiachi.Location = new System.Drawing.Point(624, 37);
            this.rtbDiachi.Name = "rtbDiachi";
            this.rtbDiachi.Size = new System.Drawing.Size(236, 54);
            this.rtbDiachi.TabIndex = 18;
            this.rtbDiachi.Text = "";
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(149, 278);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(75, 30);
            this.btnTaomoi.TabIndex = 13;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(836, 278);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(538, 278);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(416, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(283, 278);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(624, 123);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(144, 22);
            this.txtDienthoai.TabIndex = 10;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(261, 134);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(144, 22);
            this.txtTenkh.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(261, 37);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.ReadOnly = true;
            this.txtMakh.Size = new System.Drawing.Size(144, 22);
            this.txtMakh.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã khách hàng";
            // 
            // dgvKhachang
            // 
            this.dgvKhachang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachang.Location = new System.Drawing.Point(32, 381);
            this.dgvKhachang.Name = "dgvKhachang";
            this.dgvKhachang.ReadOnly = true;
            this.dgvKhachang.RowHeadersWidth = 51;
            this.dgvKhachang.RowTemplate.Height = 24;
            this.dgvKhachang.Size = new System.Drawing.Size(936, 264);
            this.dgvKhachang.TabIndex = 5;
            this.dgvKhachang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachang_CellClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(674, 278);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(75, 30);
            this.btnRefesh.TabIndex = 19;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // frKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.rtbDiachi);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhachang);
            this.Name = "frKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDiachi;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachang;
        private System.Windows.Forms.Button btnRefesh;
    }
}