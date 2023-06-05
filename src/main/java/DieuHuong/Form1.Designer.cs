namespace DieuHuong
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbCateId = new System.Windows.Forms.TextBox();
            this.btnDeleteCates = new System.Windows.Forms.Button();
            this.btnEditCate = new System.Windows.Forms.Button();
            this.btnSaveCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.lbCateName = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbPrdId = new System.Windows.Forms.TextBox();
            this.cbPrdCateId = new System.Windows.Forms.ComboBox();
            this.btnDeletePrd = new System.Windows.Forms.Button();
            this.btnEditPrd = new System.Windows.Forms.Button();
            this.btnSavePrd = new System.Windows.Forms.Button();
            this.btnAddPrd = new System.Windows.Forms.Button();
            this.tbPrdQuantity = new System.Windows.Forms.TextBox();
            this.tbPrdPrice = new System.Windows.Forms.TextBox();
            this.tbPrdImage = new System.Windows.Forms.TextBox();
            this.tbPrdName = new System.Windows.Forms.TextBox();
            this.lbPrdCateId = new System.Windows.Forms.Label();
            this.lbPrdQuantity = new System.Windows.Forms.Label();
            this.lbPrdImage = new System.Windows.Forms.Label();
            this.lbPrdPrice = new System.Windows.Forms.Label();
            this.lbPrdName = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbCateId);
            this.tabPage1.Controls.Add(this.btnDeleteCates);
            this.tabPage1.Controls.Add(this.btnEditCate);
            this.tabPage1.Controls.Add(this.btnSaveCate);
            this.tabPage1.Controls.Add(this.btnAddCate);
            this.tabPage1.Controls.Add(this.tbCateName);
            this.tabPage1.Controls.Add(this.lbCateName);
            this.tabPage1.Controls.Add(this.dgvCategory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh Mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbCateId
            // 
            this.tbCateId.Location = new System.Drawing.Point(1, 403);
            this.tbCateId.Name = "tbCateId";
            this.tbCateId.Size = new System.Drawing.Size(10, 22);
            this.tbCateId.TabIndex = 7;
            this.tbCateId.Visible = false;
            // 
            // btnDeleteCates
            // 
            this.btnDeleteCates.Enabled = false;
            this.btnDeleteCates.Location = new System.Drawing.Point(333, 340);
            this.btnDeleteCates.Name = "btnDeleteCates";
            this.btnDeleteCates.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCates.TabIndex = 6;
            this.btnDeleteCates.Text = "Xoá";
            this.btnDeleteCates.UseVisualStyleBackColor = true;
            this.btnDeleteCates.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnEditCate
            // 
            this.btnEditCate.Enabled = false;
            this.btnEditCate.Location = new System.Drawing.Point(236, 340);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(75, 23);
            this.btnEditCate.TabIndex = 5;
            this.btnEditCate.Text = "Sửa ";
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // btnSaveCate
            // 
            this.btnSaveCate.Enabled = false;
            this.btnSaveCate.Location = new System.Drawing.Point(138, 340);
            this.btnSaveCate.Name = "btnSaveCate";
            this.btnSaveCate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCate.TabIndex = 4;
            this.btnSaveCate.Text = "Lưu";
            this.btnSaveCate.UseVisualStyleBackColor = true;
            this.btnSaveCate.Click += new System.EventHandler(this.btnSaveCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(33, 340);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(75, 23);
            this.btnAddCate.TabIndex = 3;
            this.btnAddCate.Text = "Thêm mới";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // tbCateName
            // 
            this.tbCateName.Enabled = false;
            this.tbCateName.Location = new System.Drawing.Point(166, 286);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(251, 22);
            this.tbCateName.TabIndex = 2;
            // 
            // lbCateName
            // 
            this.lbCateName.Enabled = false;
            this.lbCateName.Location = new System.Drawing.Point(33, 289);
            this.lbCateName.Name = "lbCateName";
            this.lbCateName.Size = new System.Drawing.Size(100, 23);
            this.lbCateName.TabIndex = 1;
            this.lbCateName.Text = "Tên danh mục";
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(1, 3);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(790, 267);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickCate);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbPrdId);
            this.tabPage2.Controls.Add(this.cbPrdCateId);
            this.tabPage2.Controls.Add(this.btnDeletePrd);
            this.tabPage2.Controls.Add(this.btnEditPrd);
            this.tabPage2.Controls.Add(this.btnSavePrd);
            this.tabPage2.Controls.Add(this.btnAddPrd);
            this.tabPage2.Controls.Add(this.tbPrdQuantity);
            this.tabPage2.Controls.Add(this.tbPrdPrice);
            this.tabPage2.Controls.Add(this.tbPrdImage);
            this.tabPage2.Controls.Add(this.tbPrdName);
            this.tabPage2.Controls.Add(this.lbPrdCateId);
            this.tabPage2.Controls.Add(this.lbPrdQuantity);
            this.tabPage2.Controls.Add(this.lbPrdImage);
            this.tabPage2.Controls.Add(this.lbPrdPrice);
            this.tabPage2.Controls.Add(this.lbPrdName);
            this.tabPage2.Controls.Add(this.dgvProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbPrdId
            // 
            this.tbPrdId.Location = new System.Drawing.Point(0, 403);
            this.tbPrdId.Name = "tbPrdId";
            this.tbPrdId.Size = new System.Drawing.Size(10, 22);
            this.tbPrdId.TabIndex = 16;
            // 
            // cbPrdCateId
            // 
            this.cbPrdCateId.FormattingEnabled = true;
            this.cbPrdCateId.Location = new System.Drawing.Point(133, 385);
            this.cbPrdCateId.Name = "cbPrdCateId";
            this.cbPrdCateId.Size = new System.Drawing.Size(266, 24);
            this.cbPrdCateId.TabIndex = 15;
            // 
            // btnDeletePrd
            // 
            this.btnDeletePrd.Enabled = false;
            this.btnDeletePrd.Location = new System.Drawing.Point(574, 326);
            this.btnDeletePrd.Name = "btnDeletePrd";
            this.btnDeletePrd.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePrd.TabIndex = 14;
            this.btnDeletePrd.Text = "Xoá";
            this.btnDeletePrd.UseVisualStyleBackColor = true;
            this.btnDeletePrd.Click += new System.EventHandler(this.btnDeletePrd_Click);
            // 
            // btnEditPrd
            // 
            this.btnEditPrd.Enabled = false;
            this.btnEditPrd.Location = new System.Drawing.Point(464, 326);
            this.btnEditPrd.Name = "btnEditPrd";
            this.btnEditPrd.Size = new System.Drawing.Size(75, 23);
            this.btnEditPrd.TabIndex = 13;
            this.btnEditPrd.Text = "Sửa";
            this.btnEditPrd.UseVisualStyleBackColor = true;
            this.btnEditPrd.Click += new System.EventHandler(this.btnEditPrd_Click);
            // 
            // btnSavePrd
            // 
            this.btnSavePrd.Enabled = false;
            this.btnSavePrd.Location = new System.Drawing.Point(574, 280);
            this.btnSavePrd.Name = "btnSavePrd";
            this.btnSavePrd.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrd.TabIndex = 12;
            this.btnSavePrd.Text = "Lưu";
            this.btnSavePrd.UseVisualStyleBackColor = true;
            this.btnSavePrd.Click += new System.EventHandler(this.btnSavePrd_Click);
            // 
            // btnAddPrd
            // 
            this.btnAddPrd.Location = new System.Drawing.Point(464, 280);
            this.btnAddPrd.Name = "btnAddPrd";
            this.btnAddPrd.Size = new System.Drawing.Size(90, 23);
            this.btnAddPrd.TabIndex = 11;
            this.btnAddPrd.Text = "Thêm mới";
            this.btnAddPrd.UseVisualStyleBackColor = true;
            this.btnAddPrd.Click += new System.EventHandler(this.btnAddPrd_Click);
            // 
            // tbPrdQuantity
            // 
            this.tbPrdQuantity.Enabled = false;
            this.tbPrdQuantity.Location = new System.Drawing.Point(133, 355);
            this.tbPrdQuantity.Name = "tbPrdQuantity";
            this.tbPrdQuantity.Size = new System.Drawing.Size(266, 22);
            this.tbPrdQuantity.TabIndex = 10;
            // 
            // tbPrdPrice
            // 
            this.tbPrdPrice.Enabled = false;
            this.tbPrdPrice.Location = new System.Drawing.Point(133, 300);
            this.tbPrdPrice.Name = "tbPrdPrice";
            this.tbPrdPrice.Size = new System.Drawing.Size(266, 22);
            this.tbPrdPrice.TabIndex = 9;
            // 
            // tbPrdImage
            // 
            this.tbPrdImage.Enabled = false;
            this.tbPrdImage.Location = new System.Drawing.Point(133, 327);
            this.tbPrdImage.Name = "tbPrdImage";
            this.tbPrdImage.Size = new System.Drawing.Size(266, 22);
            this.tbPrdImage.TabIndex = 8;
            // 
            // tbPrdName
            // 
            this.tbPrdName.Enabled = false;
            this.tbPrdName.Location = new System.Drawing.Point(133, 268);
            this.tbPrdName.Name = "tbPrdName";
            this.tbPrdName.Size = new System.Drawing.Size(266, 22);
            this.tbPrdName.TabIndex = 6;
            // 
            // lbPrdCateId
            // 
            this.lbPrdCateId.Enabled = false;
            this.lbPrdCateId.Location = new System.Drawing.Point(0, 386);
            this.lbPrdCateId.Name = "lbPrdCateId";
            this.lbPrdCateId.Size = new System.Drawing.Size(100, 23);
            this.lbPrdCateId.TabIndex = 5;
            this.lbPrdCateId.Text = "Danh mục:";
            // 
            // lbPrdQuantity
            // 
            this.lbPrdQuantity.Enabled = false;
            this.lbPrdQuantity.Location = new System.Drawing.Point(0, 358);
            this.lbPrdQuantity.Name = "lbPrdQuantity";
            this.lbPrdQuantity.Size = new System.Drawing.Size(100, 23);
            this.lbPrdQuantity.TabIndex = 4;
            this.lbPrdQuantity.Text = "Số lượng:";
            // 
            // lbPrdImage
            // 
            this.lbPrdImage.Enabled = false;
            this.lbPrdImage.Location = new System.Drawing.Point(0, 330);
            this.lbPrdImage.Name = "lbPrdImage";
            this.lbPrdImage.Size = new System.Drawing.Size(117, 23);
            this.lbPrdImage.TabIndex = 3;
            this.lbPrdImage.Text = "Ảnh sản phẩm:";
            // 
            // lbPrdPrice
            // 
            this.lbPrdPrice.Enabled = false;
            this.lbPrdPrice.Location = new System.Drawing.Point(0, 303);
            this.lbPrdPrice.Name = "lbPrdPrice";
            this.lbPrdPrice.Size = new System.Drawing.Size(100, 23);
            this.lbPrdPrice.TabIndex = 2;
            this.lbPrdPrice.Text = "Giá sản phẩm:";
            // 
            // lbPrdName
            // 
            this.lbPrdName.Enabled = false;
            this.lbPrdName.Location = new System.Drawing.Point(-4, 271);
            this.lbPrdName.Name = "lbPrdName";
            this.lbPrdName.Size = new System.Drawing.Size(121, 23);
            this.lbPrdName.TabIndex = 1;
            this.lbPrdName.Text = " Tên sản phẩm:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(3, 1);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(792, 257);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickPrd);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbCateId;
        private System.Windows.Forms.TextBox tbPrdId;

        private System.Windows.Forms.ComboBox cbPrdCateId;

        private System.Windows.Forms.Button btnAddPrd;
        private System.Windows.Forms.Button btnSavePrd;
        private System.Windows.Forms.Button btnEditPrd;
        private System.Windows.Forms.Button btnDeletePrd;

        private System.Windows.Forms.TextBox tbPrdName;
        private System.Windows.Forms.TextBox tbPrdImage;
        private System.Windows.Forms.TextBox tbPrdPrice;
        private System.Windows.Forms.TextBox tbPrdQuantity;

        private System.Windows.Forms.Label lbPrdName;
        private System.Windows.Forms.Label lbPrdPrice;
        private System.Windows.Forms.Label lbPrdImage;
        private System.Windows.Forms.Label lbPrdQuantity;
        private System.Windows.Forms.Label lbPrdCateId;

        private System.Windows.Forms.DataGridView dgvProduct;

        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnSaveCate;
        private System.Windows.Forms.Button btnEditCate;
        private System.Windows.Forms.Button btnDeleteCates;

        private System.Windows.Forms.TextBox tbCateName;

        private System.Windows.Forms.Label lbCateName;

        private System.Windows.Forms.DataGridView dgvCategory;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}