namespace Lab4.Bai7
{
    partial class Form7
    {
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

        private void InitializeComponent()
        {
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblDishID = new System.Windows.Forms.Label();
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.lblDishName = new System.Windows.Forms.Label();
            this.btnGetDishes = new System.Windows.Forms.Button();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.lblDishes = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(12, 16);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(126, 17);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Access Token (B5):";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Location = new System.Drawing.Point(144, 15);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(644, 40);
            this.txtToken.TabIndex = 1;
            this.txtToken.Text = "Token lấy từ Bài 5 (ví dụ: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVC...). Phải là token hợp lệ.";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.lblDishID);
            this.groupBoxInput.Controls.Add(this.txtDishID);
            this.groupBoxInput.Controls.Add(this.rtbResult);
            this.groupBoxInput.Controls.Add(this.lblResult);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Controls.Add(this.btnUpdate);
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Controls.Add(this.txtDescription);
            this.groupBoxInput.Controls.Add(this.lblDescription);
            this.groupBoxInput.Controls.Add(this.txtPrice);
            this.groupBoxInput.Controls.Add(this.lblPrice);
            this.groupBoxInput.Controls.Add(this.txtDishName);
            this.groupBoxInput.Controls.Add(this.lblDishName);
            this.groupBoxInput.Location = new System.Drawing.Point(15, 61);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(773, 215);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Thao tác Món ăn (POST, PUT, DELETE)";
            // 
            // lblDishID
            // 
            this.lblDishID.AutoSize = true;
            this.lblDishID.Location = new System.Drawing.Point(340, 26);
            this.lblDishID.Name = "lblDishID";
            this.lblDishID.Size = new System.Drawing.Size(51, 13);
            this.lblDishID.TabIndex = 12;
            this.lblDishID.Text = "Dish ID:";
            // 
            // txtDishID
            // 
            this.txtDishID.Location = new System.Drawing.Point(397, 23);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(100, 20);
            this.txtDishID.TabIndex = 11;
            this.txtDishID.Text = "ID khi UPDATE/DELETE";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(503, 44);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(264, 165);
            this.rtbResult.TabIndex = 10;
            this.rtbResult.Text = "Kết quả API sẽ hiển thị ở đây...";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(500, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 17);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Kết quả:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(365, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE (Xóa)";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(240, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "PUT (Cập nhật)";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(115, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "POST (Thêm)";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(115, 87);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(370, 79);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "Mô tả món ăn";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Mô tả:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(219, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "50000";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá:";
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(115, 23);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(219, 20);
            this.txtDishName.TabIndex = 1;
            this.txtDishName.Text = "Tên món ăn mới";
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Location = new System.Drawing.Point(15, 26);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(94, 13);
            this.lblDishName.TabIndex = 0;
            this.lblDishName.Text = "Tên Món ăn/ID:";
            // 
            // btnGetDishes
            // 
            this.btnGetDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDishes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDishes.Location = new System.Drawing.Point(648, 282);
            this.btnGetDishes.Name = "btnGetDishes";
            this.btnGetDishes.Size = new System.Drawing.Size(140, 30);
            this.btnGetDishes.TabIndex = 3;
            this.btnGetDishes.Text = "GET Danh sách";
            this.btnGetDishes.UseVisualStyleBackColor = true;
            // 
            // dgvDishes
            // 
            this.dgvDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(15, 318);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.ReadOnly = true;
            this.dgvDishes.Size = new System.Drawing.Size(773, 270);
            this.dgvDishes.TabIndex = 4;
            // 
            // lblDishes
            // 
            this.lblDishes.AutoSize = true;
            this.lblDishes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishes.Location = new System.Drawing.Point(12, 290);
            this.lblDishes.Name = "lblDishes";
            this.lblDishes.Size = new System.Drawing.Size(126, 17);
            this.lblDishes.TabIndex = 5;
            this.lblDishes.Text = "Danh sách Món ăn:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblDishes);
            this.Controls.Add(this.dgvDishes);
            this.Controls.Add(this.btnGetDishes);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Name = "Form7";
            this.Text = "Bài 7: Ứng dụng CRUD Món ăn (POST, PUT, DELETE, GET)";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các đối tượng Control
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Button btnGetDishes;
        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.Label lblDishes;
        private System.Windows.Forms.Label lblDishID;
        private System.Windows.Forms.TextBox txtDishID;
    }
}