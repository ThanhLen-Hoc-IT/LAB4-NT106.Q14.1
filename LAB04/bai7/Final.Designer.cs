namespace Lab4.Bai7.Final   
{
    partial class Final
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.pbDish = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.gbAuth.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuth
            // 
            this.gbAuth.Controls.Add(this.btnLogin);
            this.gbAuth.Controls.Add(this.txtPassword);
            this.gbAuth.Controls.Add(this.label5);
            this.gbAuth.Controls.Add(this.txtUsername);
            this.gbAuth.Controls.Add(this.label4);
            this.gbAuth.Controls.Add(this.txtToken);
            this.gbAuth.Controls.Add(this.labelToken);
            this.gbAuth.Location = new System.Drawing.Point(12, 12);
            this.gbAuth.Name = "gbAuth";
            this.gbAuth.Size = new System.Drawing.Size(860, 80);
            this.gbAuth.TabIndex = 0;
            this.gbAuth.TabStop = false;
            this.gbAuth.Text = "1. Xác thực (Đăng nhập để lấy Token)";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(365, 17);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 25);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(230, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "123456";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(45, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "phatpt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(55, 50);
            this.txtToken.Name = "txtToken";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(790, 20);
            this.txtToken.TabIndex = 1;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.Location = new System.Drawing.Point(6, 53);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(46, 13);
            this.labelToken.TabIndex = 0;
            this.labelToken.Text = "Token:";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.pbDish);
            this.groupBoxData.Controls.Add(this.lblPage);
            this.groupBoxData.Controls.Add(this.numPage);
            this.groupBoxData.Controls.Add(this.cbMode);
            this.groupBoxData.Controls.Add(this.btnRandom);
            this.groupBoxData.Controls.Add(this.dgvDishes);
            this.groupBoxData.Location = new System.Drawing.Point(12, 100);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(860, 320);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "2. Danh sách Món ăn (All & My Dishes)";
            // 
            // pbDish
            // 
            this.pbDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDish.Location = new System.Drawing.Point(680, 53);
            this.pbDish.Name = "pbDish";
            this.pbDish.Size = new System.Drawing.Size(165, 165);
            this.pbDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDish.TabIndex = 6;
            this.pbDish.TabStop = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(215, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(38, 13);
            this.lblPage.TabIndex = 5;
            this.lblPage.Text = "Trang:";
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(259, 22);
            this.numPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(55, 20);
            this.numPage.TabIndex = 4;
            this.numPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] { "Tất cả (Cộng đồng)", "Món của tôi" });
            this.cbMode.Location = new System.Drawing.Point(7, 21);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(180, 21);
            this.cbMode.TabIndex = 3;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Orange;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(340, 19);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(150, 28);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "🎲 HÔM NAY ĂN GÌ?";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // dgvDishes
            // 
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(7, 53);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.ReadOnly = true;
            this.dgvDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishes.Size = new System.Drawing.Size(660, 260);
            this.dgvDishes.TabIndex = 1;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnDelete);
            this.groupBoxAction.Controls.Add(this.btnAdd);
            this.groupBoxAction.Controls.Add(this.txtPrice);
            this.groupBoxAction.Controls.Add(this.label3);
            this.groupBoxAction.Controls.Add(this.txtAddress);
            this.groupBoxAction.Controls.Add(this.label2);
            this.groupBoxAction.Controls.Add(this.txtName);
            this.groupBoxAction.Controls.Add(this.label1);
            this.groupBoxAction.Location = new System.Drawing.Point(12, 430);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(460, 150);
            this.groupBoxAction.TabIndex = 3;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "3. Thao tác (Thêm / Xóa)";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(350, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "XÓA MÓN";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(350, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "THÊM MÓN";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(86, 61);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món:";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(485, 436);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(387, 144);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.gbAuth);
            this.Name = "Form7";
            this.Text = "Bài 7: Hôm nay ăn gì? - Full Features";
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.PictureBox pbDish;
    }
}