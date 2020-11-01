namespace QLBanHangDienTu
{
    partial class frTimKiemHang
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtThoigianbaohanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMaloai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbManhom = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Thời gian BH";
            // 
            // txtThoigianbaohanh
            // 
            this.txtThoigianbaohanh.Location = new System.Drawing.Point(393, 147);
            this.txtThoigianbaohanh.Name = "txtThoigianbaohanh";
            this.txtThoigianbaohanh.Size = new System.Drawing.Size(184, 22);
            this.txtThoigianbaohanh.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã loại";
            // 
            // cbbMaloai
            // 
            this.cbbMaloai.FormattingEnabled = true;
            this.cbbMaloai.Location = new System.Drawing.Point(390, 87);
            this.cbbMaloai.Name = "cbbMaloai";
            this.cbbMaloai.Size = new System.Drawing.Size(187, 24);
            this.cbbMaloai.TabIndex = 16;
            this.cbbMaloai.DropDown += new System.EventHandler(this.cbbMaloai_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã nhóm";
            // 
            // cbbManhom
            // 
            this.cbbManhom.FormattingEnabled = true;
            this.cbbManhom.Location = new System.Drawing.Point(390, 30);
            this.cbbManhom.Name = "cbbManhom";
            this.cbbManhom.Size = new System.Drawing.Size(187, 24);
            this.cbbManhom.TabIndex = 14;
            this.cbbManhom.DropDown += new System.EventHandler(this.cbbManhom_DropDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 310);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(274, 236);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(84, 28);
            this.btnTimkiem.TabIndex = 21;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(467, 236);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(102, 28);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // frTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtThoigianbaohanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMaloai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbManhom);
            this.Name = "frTimKiem";
            this.Text = "frTimKiem";
            this.Load += new System.EventHandler(this.frTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThoigianbaohanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMaloai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbManhom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLammoi;
    }
}