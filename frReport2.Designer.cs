namespace QLBanHangDienTu
{
    partial class frReport2
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
            this.lblempty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(396, 446);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(114, 17);
            this.lblempty.TabIndex = 9;
            this.lblempty.Text = "Không có dữ liệu";
            this.lblempty.Click += new System.EventHandler(this.lblempty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MaNCC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(647, 125);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(91, 33);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(324, 130);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(249, 24);
            this.cbbNCC.TabIndex = 6;
            this.cbbNCC.DropDown += new System.EventHandler(this.cbbNCC_DropDown);
            this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 245);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 446);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "BÁO CÁO HÓA ĐƠN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport2";
            this.Text = "Báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbbNCC;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
    }
}