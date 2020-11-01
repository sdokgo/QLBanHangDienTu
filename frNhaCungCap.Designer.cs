namespace QLBanHangDienTu
{
    partial class frNhaCungCap
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
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.rtbDiachi = new System.Windows.Forms.RichTextBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Location = new System.Drawing.Point(28, 381);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.ReadOnly = true;
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.Size = new System.Drawing.Size(936, 264);
            this.dgvNhaCC.TabIndex = 0;
            this.dgvNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(238, 37);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(144, 22);
            this.txtMaNCC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NCC";
            // 
            // txtTenncc
            // 
            this.txtTenncc.Location = new System.Drawing.Point(238, 129);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(144, 22);
            this.txtTenncc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điện thoại";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(620, 123);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(144, 22);
            this.txtDienthoai.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(270, 278);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(386, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(515, 278);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(767, 278);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(145, 278);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(75, 30);
            this.btnTaomoi.TabIndex = 3;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // rtbDiachi
            // 
            this.rtbDiachi.Location = new System.Drawing.Point(620, 37);
            this.rtbDiachi.Name = "rtbDiachi";
            this.rtbDiachi.Size = new System.Drawing.Size(236, 54);
            this.rtbDiachi.TabIndex = 4;
            this.rtbDiachi.Text = "";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(637, 278);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 30);
            this.btnLammoi.TabIndex = 5;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click_1);
            // 
            // frNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.rtbDiachi);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtTenncc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhaCC);
            this.Name = "frNhaCungCap";
            this.Text = "frNhaCungCap";
            this.Load += new System.EventHandler(this.frNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.RichTextBox rtbDiachi;
        private System.Windows.Forms.Button btnLammoi;
    }
}