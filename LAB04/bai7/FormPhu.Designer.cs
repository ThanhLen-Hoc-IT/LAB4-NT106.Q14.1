namespace Lab4.Bai7
{
    partial class FormPhu
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
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(13, 13);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(99, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Token (Từ Bài 5):";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(118, 10);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(654, 20);
            this.txtToken.TabIndex = 1;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.lblPage);
            this.groupBoxData.Controls.Add(this.numPage);
            this.groupBoxData.Controls.Add(this.cbMode);
            this.groupBoxData.Controls.Add(this.btnRandom);
            this.groupBoxData.Controls.Add(this.dgvDishes);
            this.groupBoxData.Controls.Add(this.btnLoad);
            this.groupBoxData.Location = new System.Drawing.Point(16, 45);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(756, 320);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Danh sách Món ăn";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(198, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(38, 13);
            this.lblPage.TabIndex = 5;
            this.lblPage.Text = "Trang:";
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(242, 22);
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
            this.cbMode.Size = new System.Drawing.Size(170, 21);
            this.cbMode.TabIndex = 3;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(623, 19);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 28);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "🎲 ĂN GÌ GIỜ?";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // dgvDishes
            // 
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(7, 53);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.ReadOnly = true;
            this.dgvDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishes.Size = new System.Drawing.Size(743, 261);
            this.dgvDishes.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(313, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 25);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
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
            this.groupBoxAction.Location = new System.Drawing.Point(16, 371);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(434, 150);
            this.groupBoxAction.TabIndex = 3;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Thêm / Xóa Món";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(344, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "XÓA MÓN ĐANG CHỌN";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(344, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "THÊM MÓN";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(86, 61);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(239, 20);
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
            this.txtAddress.Size = new System.Drawing.Size(239, 20);
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
            this.txtName.Size = new System.Drawing.Size(239, 20);
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
            this.rtbLog.Location = new System.Drawing.Point(456, 378);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(316, 143);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form7";
            this.Text = "Bài 7: Hôm nay ăn gì? (Version 4)";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Button btnLoad;
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
    }
}