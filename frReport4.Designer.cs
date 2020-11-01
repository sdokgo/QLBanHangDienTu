namespace QLBanHangDienTu
{
    partial class frReport4
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblempty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(345, 151);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(136, 30);
            this.cbbNam.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "BÁO CÁO NHÀ CUNG CẤP";
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(396, 440);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(114, 17);
            this.lblempty.TabIndex = 23;
            this.lblempty.Text = "Không có dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tháng";
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(544, 119);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(91, 33);
            this.btnChon.TabIndex = 21;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(345, 94);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(136, 30);
            this.cbbThang.TabIndex = 20;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 239);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 446);
            this.reportViewer1.TabIndex = 19;
            // 
            // frReport4
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
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport4";
            this.Text = "frReport4";
            this.Load += new System.EventHandler(this.frReport4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbbThang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}