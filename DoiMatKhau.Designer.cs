namespace QLBanHangDienTu
{
    partial class DoiMatKhau
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(168, 96);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(154, 20);
            this.txtMKM.TabIndex = 11;
            this.txtMKM.UseSystemPasswordChar = true;
            this.txtMKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKM_KeyPress);
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(168, 65);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(154, 20);
            this.txtMKC.TabIndex = 10;
            this.txtMKC.UseSystemPasswordChar = true;
            this.txtMKC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // txtMKM2
            // 
            this.txtMKM2.Location = new System.Drawing.Point(168, 127);
            this.txtMKM2.Name = "txtMKM2";
            this.txtMKM2.Size = new System.Drawing.Size(154, 20);
            this.txtMKM2.TabIndex = 15;
            this.txtMKM2.UseSystemPasswordChar = true;
            this.txtMKM2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKM2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 241);
            this.Controls.Add(this.txtMKM2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKM2;
        private System.Windows.Forms.Label label4;
    }
}