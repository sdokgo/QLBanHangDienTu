namespace QLBanHangDienTu
{
    partial class frReport1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbManv = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblempty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 212);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbbManv
            // 
            this.cbbManv.FormattingEnabled = true;
            this.cbbManv.Location = new System.Drawing.Point(330, 134);
            this.cbbManv.Name = "cbbManv";
            this.cbbManv.Size = new System.Drawing.Size(249, 24);
            this.cbbManv.TabIndex = 1;
            this.cbbManv.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(641, 129);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(91, 33);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân viên";
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(396, 497);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(114, 17);
            this.lblempty.TabIndex = 4;
            this.lblempty.Text = "Không có dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(236, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "BÁO CÁO SẢN PHẨM";
            // 
            // frReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbManv);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport1";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frReport1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbbManv;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label2;
    }
}