namespace QLBanHangDienTu
{
    partial class frReport3
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblempty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbQuy = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "BÁO CÁO DOANH THU";
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(396, 442);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(114, 17);
            this.lblempty.TabIndex = 15;
            this.lblempty.Text = "Không có dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Qúy";
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(544, 121);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(91, 33);
            this.btnChon.TabIndex = 13;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbbQuy
            // 
            this.cbbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuy.FormattingEnabled = true;
            this.cbbQuy.Location = new System.Drawing.Point(345, 96);
            this.cbbQuy.Name = "cbbQuy";
            this.cbbQuy.Size = new System.Drawing.Size(136, 30);
            this.cbbQuy.TabIndex = 12;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 207);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 480);
            this.reportViewer1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(345, 153);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(136, 30);
            this.cbbNam.TabIndex = 17;
            // 
            // frReport3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbQuy);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport3";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frReport3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbbQuy;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNam;
    }
}