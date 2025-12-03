namespace Lab4.Bai5 // Đảm bảo đúng Namespace của m
{
    partial class Form5
    {
        // Các biến cần thiết cho việc quản lý tài nguyên
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPOST = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HTTP POST: ĐĂNG NHẬP VỚI API (BÀI 5)";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "phatpt"; // Giá trị mặc định
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•'; 
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123456"; // Giá trị mặc định
            // 
            // btnPOST
            // 
            this.btnPOST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOST.Location = new System.Drawing.Point(376, 70);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(120, 55);
            this.btnPOST.TabIndex = 5;
            this.btnPOST.Text = "ĐĂNG NHẬP (POST)";
            this.btnPOST.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(50, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(130, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Kết quả Phản hồi:";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(53, 165);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(443, 200);
            this.rtbResult.TabIndex = 7;
            this.rtbResult.Text = "Thông tin token sẽ hiển thị tại đây sau khi đăng nhập thành công...";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400); 
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPOST);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form5";
            this.Text = "Bài 5: HTTP POST - Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // KHAI BÁO CÁC ĐỐI TƯỢNG CONTROL (Rất quan trọng)
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}